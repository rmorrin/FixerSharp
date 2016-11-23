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

        public string From { get; }

        public string To { get; }

        public double Rate { get; }

        public double Convert(double amount)
        {
            return amount * Rate;
        }
    }
}
