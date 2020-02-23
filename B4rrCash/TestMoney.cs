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
        public void TestDollarMultiplication()
        {
            Money fiveDollars = Money.Dollar(5);
            Money tenDollars = Money.Dollar(2 * 5);
            Assert.AreEqual(tenDollars, 2 * fiveDollars);
            Assert.AreEqual(tenDollars, fiveDollars * 2);
        }

        [Test]
        public void TestFrancMultiplication()
        {
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
            Assert.AreEqual("CHF", fiveFrancs.GetCurrency());
        }
    }
}
