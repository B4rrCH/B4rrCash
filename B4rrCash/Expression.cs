using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Wallet
    {
        private Dictionary<string, int> currencyAmounts;

        public Wallet(IEnumerable<Money> source)
        {
            currencyAmounts = new Dictionary<string, int>();
            foreach (Money money in source)
                if (currencyAmounts.ContainsKey(money.Currency))
                    currencyAmounts[money.Currency] += money.Amount;
                else
                    currencyAmounts[money.Currency] = money.Amount;

        }
    }
}
