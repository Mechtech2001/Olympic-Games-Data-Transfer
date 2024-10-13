using System.Text.Json;

namespace Olympic_Games_Data_Transfer.Models
{
    public static class SessionExtension
    {
        public static void SetObject <T>(this ISession session, string key, T value) {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T? GetObject<T>(this ISession session, string key)
        {
            var json = session.GetString(key);
            return (string.IsNullOrEmpty(json)) ? default(T) :
            JsonSerializer.Deserialize<T>(json);
        }
    }
}
