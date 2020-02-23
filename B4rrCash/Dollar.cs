﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Dollar
    {
        private int Amount {get; set;}
        public Dollar(int amount)
        {
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

        public override bool Equals(object obj)
        {
            return obj is Dollar dollar &&
                   Amount == dollar.Amount;
        }

        public override int GetHashCode()
        {
            return -602769199 + Amount.GetHashCode();
        }
    }
}
