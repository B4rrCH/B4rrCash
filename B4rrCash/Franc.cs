using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Franc : Money
    {
        public Franc(int amount)
        {
            this.Currency = "CHF";
            this.Amount = amount;
        }

        public override Money times(int factor) => new Franc(factor * Amount);

    }
}
