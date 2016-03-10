using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManager;
using NSubstitute;

namespace StockManager._Test
{
    [TestClass]
    public class MockTest
    {
        private static String TALISKER = "Talisker";

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
        public void testFillingRemovesInventoryIfInStock()
        {
            //setup - data
            Order order = new Order(TALISKER, 50);
            IWarehouse warehouseMock = Substitute.For<IWarehouse>();
            

            //setup - expectations
            warehouseMock.hasInventory(TALISKER, 50).Returns(true);
            warehouseMock.remove(TALISKER, 50);

            //exercise
            order.fill(warehouseMock);

            //verify
            warehouseMock.Received().hasInventory(TALISKER, 50);
            warehouseMock.Received().remove(TALISKER, 50);

            Assert.IsTrue(order.isFilled);
        }

        [TestMethod]
        public void testFillingDoesNotRemoveIfNotEnoughInStock()
        {
            //setup - data
            Order order = new Order(TALISKER, 51);
            IWarehouse warehouseMock = Substitute.For<IWarehouse>();

            //setup - expectations
            warehouseMock.hasInventory(TALISKER, 51).Returns(false);

            //exercise
            order.fill(warehouseMock);

            //verify
            warehouseMock.Received().hasInventory(TALISKER, 51);

            Assert.IsFalse(order.isFilled);
        }

    }
}
