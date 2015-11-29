using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FixerSharp
{
    public class Fixer
    {
        public static double Convert(string from, string to, double amount)
        {
            return GetRate(from, to).Convert(amount);
        }

        public static ExchangeRate Rate(string from, string to)
        {
            return GetRate(from, to);
        }

        private static ExchangeRate GetRate(string from, string to)
        {
            from = from.ToUpper();
            to = to.ToUpper();

            if (!Symbols.IsValid(from))
                throw new ArgumentException("Symbol not found for provided currency", "from");

            if (!Symbols.IsValid(to))
                throw new ArgumentException("Symbol not found for provided currency", "to");

            JObject rates = GetLatestRates();

            var fromRate = rates.Value<double>(from);
            var toRate = rates.Value<double>(to);

            double rate = toRate / fromRate;

            return new ExchangeRate(from, to, rate);
        }

        private static JObject GetLatestRates()
        {
            string url = "http://api.fixer.io/latest";

            using (var wc = new WebClient())
            {
                var root = JObject.Parse(wc.DownloadString(url));
                var rates = root.Value<JObject>("rates");

                // exchange base is not included in rates, add this manually
                var baseSymbol = root.Value<string>("base");
                rates.Add(baseSymbol, 1.00);

                return rates;
            }
        }
    }
}
