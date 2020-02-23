﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Franc
    {
        private int Amount { get; set; }
        public Franc(int amount)
        {
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

        public override bool Equals(object obj)
        {
            return obj is Franc franc &&
                   Amount == franc.Amount;
        }

        public override int GetHashCode()
        {
            return -602769199 + Amount.GetHashCode();
        }
    }
}
