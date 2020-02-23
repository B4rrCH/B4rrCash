using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Dollar
    {
        public int Amount {get; private set;}
        public Dollar(int amount)
        {
            this.Amount = amount;
        }

        public static Dollar operator *(int factor, Dollar dollar)
        {
            return new Dollar(factor * dollar.Amount);
        }
    }
}
