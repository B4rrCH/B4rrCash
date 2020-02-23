using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Wallet
    {
        public Dictionary<string, int> Moneys { get; private set; }
        public Wallet()
        {
            Moneys = new Dictionary<string, int>();
        }
        public Wallet(IEnumerable<Money> source)
        {
            Moneys = new Dictionary<string, int>();
            foreach (Money money in source)
                Add(money);
        }

        public void Add(Money money)
        {
            if (Moneys.ContainsKey(money.Currency))
                Moneys[money.Currency] += money.Amount;
            else
                Moneys[money.Currency] = money.Amount;
        }
    }
}
