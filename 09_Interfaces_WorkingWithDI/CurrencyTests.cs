using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTests()
        {
            ICurrency penny = new Penny();
            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }
        [TestMethod]
        public void NickelTests()
        {
            ICurrency nickel = new Nickel();
            Assert.AreEqual(0.05m, nickel.Value);
            Assert.AreEqual("Nickel", nickel.Name);
        }
        [TestMethod]
        public void DollarTest()
        {
            ICurrency dollar = new Dollar();
            Assert.AreEqual(1.0m, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }

        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(2319.18)]
        [DataRow(1408.0)]
        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var epayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, epayment.Value);
            Assert.AreEqual("Electronic Payment", epayment.Name);
        }
    }
}
