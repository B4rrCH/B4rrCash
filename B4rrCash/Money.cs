using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    class Money : Expression
    {
        public int Amount { get; protected set; }
        public string Currency { get; protected set; }

        public Money(int amount = 1, string currency = "USD")
        {
            Amount = amount;
            Currency = currency;
        }

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

        public override string ToString() => $"{Amount} {Currency}";

        public Money times(int factor)
        {
            return new Money(factor * Amount, Currency);
        }

        public static Money operator *(int factor, Money money) => money.times(factor);
        
        public static Money operator *(Money money, int factor) => money.times(factor);
        public static Expression operator +(Money money1, Money money2)
        {
            if (money1.Currency == money2.Currency)
                return new Money(money1.Amount + money2.Amount, money1.Currency);
            return new Sum(money1, money2);
        }
        public static Money Dollar(int amount) => new Money(amount, "USD");
        public static Money Franc(int amount) => new Money(amount, "CHF");
    }
}
