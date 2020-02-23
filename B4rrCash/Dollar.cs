using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Dollar : Money
    {
        public override string Currency() => "USD";
        public Dollar()
        {
            this.Amount = 1;
        }

        private Dollar(int amount)
        {
            this.Amount = amount;
        }

        public override Money times(int factor) => new Dollar(factor * Amount);
    }
}
