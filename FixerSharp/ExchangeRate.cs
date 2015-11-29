using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixerSharp
{
    public class ExchangeRate
    {
        public ExchangeRate(string from, string to, double rate)
        {
            From = from;
            To = to;
            Rate = rate;
        }

        public string From { get; private set; }

        public string To { get; private set; }

        public double Rate { get; private set; }

        public double Convert(double amount)
        {
            return amount * Rate;
        }
    }
}
