using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FixerSharp
{
    public class Fixer
    {
        private const string BaseUri = "http://data.fixer.io/api/";

        private static string _apiKey;

        private static string ApiKey
        {
            get => !string.IsNullOrWhiteSpace(_apiKey) ? _apiKey : throw new InvalidOperationException("Fixer.io now requires an API key! Call .SetApiKey(\"key\") first");
            set => _apiKey = value;
        }

        public static double Convert(string from, string to, double amount, DateTime? date = null)
        {
            return GetRate(from, to, date).Convert(amount);
        }

        public static async Task<double> ConvertAsync(string from, string to, double amount, DateTime? date = null)
        {
            return (await GetRateAsync(from, to, date)).Convert(amount);
        }

        public static ExchangeRate Rate(string from, string to, DateTime? date = null)
        {
            return GetRate(from, to, date);
        }

        public static async Task<ExchangeRate> RateAsync(string from, string to, DateTime? date = null)
        {
            return await GetRateAsync(from, to, date);
        }

        public static void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }

        private static ExchangeRate GetRate(string from, string to, DateTime? date = null)
        {
            from = from.ToUpper();
            to = to.ToUpper();

            if (!Symbols.IsValid(from))
                throw new ArgumentException("Symbol not found for provided currency", "from");

            if (!Symbols.IsValid(to))
                throw new ArgumentException("Symbol not found for provided currency", "to");

            var url = GetFixerUrl(date);

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();

                return ParseData(response.Content.ReadAsStringAsync().Result, from, to);
            }
        }

        private static async Task<ExchangeRate> GetRateAsync(string from, string to, DateTime? date = null)
        {
            from = from.ToUpper();
            to = to.ToUpper();

            if (!Symbols.IsValid(from))
                throw new ArgumentException("Symbol not found for provided currency", "from");

            if (!Symbols.IsValid(to))
                throw new ArgumentException("Symbol not found for provided currency", "to");

            var url = GetFixerUrl(date);

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return ParseData(await response.Content.ReadAsStringAsync(), from, to);
            }
        }

        private static ExchangeRate ParseData(string data, string from, string to)
        {
            // Parse JSON
            var root = JObject.Parse(data);

            var rates = root.Value<JObject>("rates");
            var fromRate = rates.Value<double>(from);
            var toRate = rates.Value<double>(to);

            var rate = toRate / fromRate;

            // Parse returned date
            // Note: This may be different to the requested date as Fixer will return the closest available
            var returnedDate = DateTime.ParseExact(root.Value<string>("date"), "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture);

            return new ExchangeRate(from, to, rate, returnedDate);
        }

        private static string GetFixerUrl(DateTime? date = null)
        {
            var dateString = date.HasValue ? date.Value.ToString("yyyy-MM-dd") : "latest";

            return $"{BaseUri}{dateString}?access_key={ApiKey}";
        }

    }
}
