using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Franc : Money
    {
        public Franc()
        {
            Currency = "CHF";
            Amount = 1;
        }

        private Franc(int amount)
        {
            Currency = "CHF";
            Amount = amount;
        }

        public override Money times(int factor) => new Franc(factor * Amount);

    }
}
