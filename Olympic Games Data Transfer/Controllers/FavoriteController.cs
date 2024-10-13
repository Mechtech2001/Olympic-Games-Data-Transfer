using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympic_Games_Data_Transfer.Models;
using System.Diagnostics.Metrics;

namespace Olympic_Games_Data_Transfer.Controllers
{
    public class FavoriteController : Controller
    {
        private CountryContext context;
        public FavoriteController(CountryContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new Models.CountryViewModel
            {
                ActiveEvent = session.GetActiveEvent(),
                ActiveSport = session.GetActiveSport(),
                countries = session.GetMyCountry()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(Country country)
        {
            country = context.Countrys
                 .Include(t => t.events)
                 .Include(t => t.sport)
                 .Where(t => t.CountryID == country.CountryID)
                 .FirstOrDefault() ?? new Country();
            var session = new OlympicSession(HttpContext.Session);
            var cookies = new OlympicCookies(Response.Cookies);

            var countries = session.GetMyCountry();
            countries.Add(country);
            session.SetMyCountry(countries);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{country.CountryName} added to your favorites";
            return RedirectToAction("Index", "Home", 
                new
                {
                    ActiveEvent = session.GetActiveEvent(),
                    ActiveSport = session.GetActiveSport()
                });

        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            var cookies = new OlympicCookies(Response.Cookies);

            session.RemoveMyCountry();
            cookies.RemoveMyCountryIds();

            TempData["message"] = $"Favorite countries cleared";
            return RedirectToAction("Index", "Home",
             new
             {
                 ActiveEvent = session.GetActiveEvent(),
                 ActiveSport = session.GetActiveSport()
             });
        }

    }
}
