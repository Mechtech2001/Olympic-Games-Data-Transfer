using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Olympic_Games_Data_Transfer.Models
{
    
    public class CountryViewModel
    {
        public Country Country { get; set; } = new Country();
        public string ActiveEvent { get; set; } = "all";
        public string ActiveSport { get; set; } = "all";

        public List<Country> countries { get; set; } = new List<Country> { };
        [BindNever]
        public List<Event> events { get; set; } = new List<Event> { };
        [BindNever]
        public List<Sport> sports { get; set; } = new List<Sport> { };

        public string CheckActiveEvent(string c) => c.ToLower() == ActiveEvent.ToLower() ? "active" : "";
        public string CheckActiveSport(string d) => d.ToLower() == ActiveSport.ToLower() ? "active" : "";
    }
}
