namespace Olympic_Games_Data_Transfer.Models
{
    public class OlympicSession
    {
        private const string CountryKey = "myCountry";
        private const string CountKey = "countrycount";
        private const string EventKey = "event";
        private const string SportKey = "sport";

        private ISession session {  get; set; }
        public OlympicSession(ISession session) => this.session = session;

        public void SetMyCountry(List<Country> country)
        {
            session.SetObject(CountryKey, country);
            session.SetInt32(CountKey, country.Count);
        }
        public List<Country> GetMyCountry() =>
            session.GetObject<List<Country>> (CountryKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void setActiveEvent(string activeEvent) =>
            session.SetString(EventKey, activeEvent);
        public string GetActiveEvent() => session.GetString(EventKey) ?? string.Empty;

        public void setActiveSport(string activeSport) =>
           session.SetString(SportKey, activeSport);
        public string GetActiveSport() => session.GetString(SportKey) ?? string.Empty;

        public void RemoveMyCountry()
        {
            session.Remove(CountryKey);
            session.Remove(CountKey);
        }
    }
}
