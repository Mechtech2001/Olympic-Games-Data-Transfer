using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympic_Games_Data_Transfer.Models;
using System.Diagnostics;

namespace Olympic_Games_Data_Transfer.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(CountryViewModel model)
        {
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
