using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockManager._Test
{
    [TestClass]
    public class CalculatorTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void testCalculatorAddTwoValuesRight()
        {
            //setup - data
            Calculator calc = new Calculator();

            //exercise
            int result = calc.add(5, 6);

            //verify
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void testCalculatorAddTwoValuesFalse()
        {
            //setup - data
            Calculator calc = new Calculator();

            //exercise
            int result = calc.add(5, 6);

            //verify
            Assert.AreNotEqual(12, result);
        }

        [TestMethod]
        public void testCalculatorSubtractTwoValuesRight()
        {
            //setup - data
            Calculator calc = new Calculator();

            //exercise
            int result = calc.subtract(11, 6);

            //verify
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void testCalculatorSubtractTwoValuesFalse()
        {
            //setup - data
            Calculator calc = new Calculator();

            //exercise
            int result = calc.add(10, 6);

            //verify
            Assert.AreNotEqual(5, result);
        }
    }
}
