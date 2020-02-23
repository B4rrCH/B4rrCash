using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.Currency = "USD";
            this.Amount = amount;
        }

        public override Money times(int factor) => new Dollar(factor * Amount);
    }
}
