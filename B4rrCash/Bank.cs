using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Bank
    {
        private Dictionary<(string, string), decimal> exchangeRates;
        public Bank()
        {
            exchangeRates = new Dictionary<(string, string), decimal>();
        }

        public void SetRate(string fromCurrency, string toCurrency, decimal rate)
        {
            exchangeRates[(fromCurrency, toCurrency)] = rate;
        }

        public Money Convert(Money money, string toCurrency)
        {
            string fromCurrency = money.Currency;
            if (fromCurrency == toCurrency)
                return money;
            int amount = (int) (money.Amount * exchangeRates[(fromCurrency, toCurrency)]);
            return new Money(amount, toCurrency);
        }

        public Money Reduce(Expression source, string toCurrency)
        {
            if (source is Sum)
            {
                Money augend = Reduce((source as Sum).Augend, toCurrency);
                Money addend = Reduce((source as Sum).Addend, toCurrency);
                return new Money(augend.Amount + addend.Amount, toCurrency);
            }

            return Convert(source as Money, toCurrency);
        }
    }
}
