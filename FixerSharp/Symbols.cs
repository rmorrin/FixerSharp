using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixerSharp
{
    public static class Symbols
    {
        public const string AUD = "AUD";
        public const string BGN = "BGN";
        public const string BRL = "BRL";
        public const string CAD = "CAD";
        public const string CHF = "CHF";
        public const string CNY = "CNY";
        public const string CZK = "CZK";
        public const string DKK = "DKK";
        public const string EUR = "EUR";
        public const string GBP = "GBP";
        public const string HKD = "HKD";
        public const string HRK = "HRK";
        public const string HUF = "HUF";
        public const string IDR = "IDR";
        public const string ILS = "ILS";
        public const string INR = "INR";
        public const string JPY = "JPY";
        public const string KRW = "KRW";
        public const string MXN = "MXN";
        public const string MYR = "MYR";
        public const string NOK = "NOK";
        public const string NZD = "NZD";
        public const string PHP = "PHP";
        public const string PLN = "PLN";
        public const string RON = "RON";
        public const string RUB = "RUB";
        public const string SEK = "SEK";
        public const string SGD = "SGD";
        public const string THB = "THB";
        public const string TRY = "TRY";
        public const string USD = "USD";
        public const string ZAR = "ZAR";

        public static bool IsValid(string symbol)
        {
            return ValidSymbols.Contains(symbol);
        }

        private static string[] ValidSymbols = new string[]
        {
            AUD,
            BGN,
            BRL,
            CAD,
            CHF,
            CNY,
            CZK,
            DKK,
            EUR,
            GBP,
            HKD,
            HRK,
            HUF,
            IDR,
            ILS,
            INR,
            JPY,
            KRW,
            MXN,
            MYR,
            NOK,
            NZD,
            PHP,
            PLN,
            RON,
            RUB,
            SEK,
            SGD,
            THB,
            TRY,
            USD,
            ZAR
        };
    }
}
