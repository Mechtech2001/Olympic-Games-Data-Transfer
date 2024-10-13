namespace Olympic_Games_Data_Transfer.Models
{
    public class OlympicCookies
    {
        private const string CountryKey = "mycountry";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; } = null!;
        private IResponseCookies responseCookies { get; set; } = null!;

        public OlympicCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public OlympicCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyCountryIds(List<Country> mycountries)
        {
            List<string> ids = mycountries.Select(t => t.CountryID).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            RemoveMyCountryIds();
            responseCookies.Append(CountryKey, idsString, options);
        }

        public string[] GetMyCountryIds()
        {
            string cookie = requestCookies["MyCountry"] ?? string.Empty;
            if (string.IsNullOrEmpty(cookie))
            {
                return Array.Empty<string>();
            } else
            {
                return cookie.Split(Delimiter);
            }

        }

        public void RemoveMyCountryIds()
        {
            responseCookies.Delete(CountryKey);
        }
    }
}
