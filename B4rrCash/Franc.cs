using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Franc : Money
    {
        public override string Currency() => "CHF";
        public Franc()
        {
            this.Amount = 1;
        }

        private Franc(int amount)
        {
            this.Amount = amount;
        }

        public override Money times(int factor) => new Franc(factor * Amount);

    }
}
