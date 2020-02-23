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

        public static Dollar operator *(int factor, Dollar dollar)
        {
            return new Dollar(factor * dollar.Amount);
        }

        public static Dollar operator *(Dollar dollar, int factor)
        {
            return new Dollar(factor * dollar.Amount);
        }
    }
}
