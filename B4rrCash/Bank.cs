using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Bank
    {
        private Dictionary<(string, string), int> exchangeRates;
        public Bank()
        {
            exchangeRates = new Dictionary<(string, string), int>();
        }

        public void AddRate(string fromCurrency, string toCurrency, int rate)
        {
            exchangeRates[(fromCurrency, toCurrency)] = rate;
        }

        public int Convert(string fromCurrency, string toCurrency, int amount)
        {
            if (fromCurrency == toCurrency)
                return amount;
            return exchangeRates[(fromCurrency, toCurrency)] * amount;
        }

        public Money Reduce(Wallet wallet, string toCurrency)
        {
            int amount = 0;
            foreach(KeyValuePair<string, int> currencyAmount in wallet.Moneys)
                amount += Convert(currencyAmount.Key, toCurrency, currencyAmount.Value);
            return new Money(amount, toCurrency);
        }
    }
}
