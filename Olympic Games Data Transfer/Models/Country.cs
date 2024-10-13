namespace Olympic_Games_Data_Transfer.Models
{
    public class Country
    {
        public string CountryID { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
        public string EventID { get; set; } = string.Empty; 
        public Event events { get; set; } = new Event();
        public Sport sport { get; set; } = new Sport();
        public string flag { get; set; } = string.Empty;
    }
}
