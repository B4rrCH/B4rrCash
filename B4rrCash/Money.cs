using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    abstract class Money
    {
        protected int Amount { get; set; }
        protected string Currency { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   Amount == money.Amount &&
                   Currency == money.Currency;
        }

        public override int GetHashCode()
        {
            var hashCode = -259941593;
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Currency);
            return hashCode;
        }
    }
}
