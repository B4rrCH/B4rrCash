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
            Dollar fiveDollars = new Dollar(5);
            Dollar tenDollars = new Dollar(2 * 5);
            Assert.AreEqual(tenDollars, 2 * fiveDollars);
            Assert.AreEqual(tenDollars, fiveDollars * 2);
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Franc fiveFrancs = new Franc(5);
            Franc tenFrancs = new Franc(2 * 5);
            Assert.AreEqual(tenFrancs, 2 * fiveFrancs);
            Assert.AreEqual(tenFrancs, fiveFrancs * 2);
        }

        [Test]
        public void TestEquality()
        {
            Dollar fiveDollars = new Dollar(5);
            Dollar fiveDollars2 = new Dollar(5);
            Dollar sixDollars = new Dollar(6);

            Assert.IsTrue(fiveDollars.Equals(fiveDollars2));
            Assert.AreNotSame(fiveDollars, fiveDollars2);

            Assert.IsFalse(fiveDollars.Equals(sixDollars));
        }
    }
}
