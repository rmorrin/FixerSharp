using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace FixerSharp
{
    public class Fixer
    {
        private const string BaseUri = "http://api.fixer.io/";

        public static double Convert(string from, string to, double amount, DateTime? date = null)
        {
            return GetRate(from, to, date).Convert(amount);
        }

        public static ExchangeRate Rate(string from, string to, DateTime? date = null)
        {
            return GetRate(from, to, date);
        }

        private static ExchangeRate GetRate(string from, string to, DateTime? date = null)
        {
            from = from.ToUpper();
            to = to.ToUpper();

            if (!Symbols.IsValid(from))
                throw new ArgumentException("Symbol not found for provided currency", "from");

            if (!Symbols.IsValid(to))
                throw new ArgumentException("Symbol not found for provided currency", "to");

            // Get data from Fixer API
            var fixerData = GetFixerData(date);

            // Parse rates
            var rates = fixerData.Value<JObject>("rates");
            var fromRate = rates.Value<double>(from);
            var toRate = rates.Value<double>(to);

            var rate = toRate / fromRate;

            // Parse returned date
            // Note: This may be different to the requested date as Fixer will return the closest available
            var returnedDate = DateTime.ParseExact(fixerData.Value<string>("date"), "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture);

            return new ExchangeRate(from, to, rate, returnedDate);
        }

        private static JObject GetFixerData(DateTime? date = null)
        {
            var dateString = date.HasValue ? date.Value.ToString("yyyy-MM-dd") : "latest";
            var url = string.Format("{0}{1}", BaseUri, dateString);

            using (var wc = new WebClient())
            {
                var root = JObject.Parse(wc.DownloadString(url));
                var rates = root.Value<JObject>("rates");

                // exchange base is not included in rates, add this manually
                var baseSymbol = root.Value<string>("base");
                rates.Add(baseSymbol, 1.00);

                return root;
            }
        }
    }
}
