namespace Olympic_Games_Data_Transfer.Models
{
    public class CountryViewModel
    {
        public string ActiveEvent { get; set; } = "all";
        public string ActiveSport { get; set; } = "all";

        public List<Country> countries { get; set; } = new List<Country> { };
        public List<Event> events { get; set; } = new List<Event> { };
        public List<Sport> sports { get; set; } = new List<Sport> { };

        public string CheckActiveEvent(string c) => c.ToLower() == ActiveEvent.ToLower() ? "active" : "";
        public string CheckActiveSport(string d) => d.ToLower() == ActiveSport.ToLower() ? "active" : "";
    }
}
