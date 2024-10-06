namespace Olympic_Games_Data_Transfer.Models
{
    public class Country
    {
        public string CountryID { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
        public Sport sport {  get; set; } = null!;
        public Event events { get; set; } = null!;
       public string flag {  get; set; } = string.Empty;
    }
}
