using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    abstract class Money
    {
        public int Amount { get; protected set; }
        public string Currency { get; protected set; }
        public string GetCurrency() => this.Currency;

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   Amount == money.Amount &&
                   GetCurrency() == money.GetCurrency();
        }

        public override int GetHashCode()
        {
            var hashCode = -259941593;
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GetCurrency());
            return hashCode;
        }

        public abstract Money times(int factor);

        public static Money operator *(int factor, Money money)
        {
            return money.times(factor);
        }
        public static Money operator *(Money money, int factor)
        {
            return money.times(factor);
        }

        public static Money Dollar(int amount) => amount * new Dollar();
        public static Money Franc(int amount) => amount * new Franc();
    }
}
