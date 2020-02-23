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

        public static Franc operator *(int factor, Franc franc)
        {
            return new Franc(factor * franc.Amount);
        }

        public static Franc operator *(Franc franc, int factor)
        {
            return new Franc(factor * franc.Amount);
        }
    }
}
