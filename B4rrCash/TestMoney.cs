using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4rrCash
{
    [TestFixture]
    public class TestMoney
    {
        [Test]
        public void TestMultiplication()
        {
            Money fiveDollars = Money.Dollar(5);
            Money tenDollars = Money.Dollar(2 * 5);
            Assert.AreEqual(tenDollars, 2 * fiveDollars);
            Assert.AreEqual(tenDollars, fiveDollars * 2);

            Money fiveFrancs = Money.Franc(5);
            Money tenFrancs = Money.Franc(2 * 5);
            Assert.AreEqual(tenFrancs, 2 * fiveFrancs);
            Assert.AreEqual(tenFrancs, fiveFrancs * 2);
        }


        [Test]
        public void TestEquality()
        {
            Money fiveDollars = Money.Dollar(5);
            Money fiveDollars2 = Money.Dollar(5);
            Money sixDollars = Money.Dollar(6);
            Money fiveFrancs = Money.Franc(5);

            Assert.IsTrue(fiveDollars.Equals(fiveDollars2));
            Assert.AreNotSame(fiveDollars, fiveDollars2);

            Assert.IsFalse(fiveDollars.Equals(sixDollars));

            Assert.IsFalse(fiveDollars.Equals(fiveFrancs));
        }

        [Test]
        public void TestCurrency()
        {
            Money fiveFrancs = Money.Franc(5);
            Assert.AreEqual("CHF", fiveFrancs.Currency);
        }

        [Test]
        public void TestAddition()
        {
            Money tenDollars = Money.Dollar(5) + Money.Dollar(5) as Money;
            Assert.AreEqual(Money.Dollar(10), tenDollars);
        }

        [Test]
        public void TestReduceSameCurrencies()
        {
            IExpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(7), result);
        }

        [Test]
        public void TestReduceDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.SetRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(4), "USD");
            Assert.AreEqual(Money.Dollar(2), result);

        }

        public void TestReduceMultipleCurrencies()
        {
            Bank bank = new Bank();
            bank.SetRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Dollar(1) + Money.Franc(2), "USD");
            Assert.AreEqual(Money.Dollar(2), result);
        }
    }
}
