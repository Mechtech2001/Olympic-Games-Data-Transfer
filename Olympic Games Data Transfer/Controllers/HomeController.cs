using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympic_Games_Data_Transfer.Models;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Olympic_Games_Data_Transfer.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }


        
        public ViewResult Index(Models.CountryViewModel model)
        {
            var session = new OlympicSession(HttpContext.Session);
            session.setActiveEvent(model.ActiveEvent);
            session.setActiveSport(model.ActiveSport);
            int? count = session.GetMyCountryCount();
            if (!count.HasValue)
            {
                var cookies = new OlympicCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                if(ids.Length > 0)
                {
                    var mycountries = context.Countrys
                         .Include(t => t.events)
                        .Include(t => t.sport)
                        .Where(t => ids.Contains(t.CountryID))
                        .ToList();
                    session.SetMyCountry(mycountries);
                }
            }

            model.events = context.Events.ToList();
            model.sports = context.Sports.ToList();

            IQueryable<Country> query = context.Countrys;



            if (model.ActiveEvent != "all")
            {
                query = query.Where(c => c.events.EventID.ToLower() == model.ActiveEvent.ToLower());

            }
            if (model.ActiveSport != "all")
            {
                query = query.Where(d => d.sport.SportID.ToLower() == model.ActiveSport.ToLower());
            }
            model.countries = query.ToList();
            return View(model);
        }

        public ViewResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new Models.CountryViewModel
            {
                Country = context.Countrys
                    .Include(t => t.events)
                    .Include(t => t.sport)
                    .FirstOrDefault(t => t.CountryID == id) ?? new Country(),
                ActiveEvent = session.GetActiveEvent(),
                ActiveSport = session.GetActiveSport()
            };
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}