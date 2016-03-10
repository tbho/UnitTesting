using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockManager._Test
{
    [TestClass]
    public class RegularTest
    {
        private static String TALISKER = "Talisker";
        private static String HIGHLAND_PARK = "Highland Park";

        private Warehouse warehouse = null;

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
            //setup - data
            warehouse = new Warehouse();
            warehouse.add(TALISKER, 50);
            warehouse.add(HIGHLAND_PARK, 25);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void testOrderIsFilledIfEnoughInWarehouse()
        {
            //setup - data
            Order order = new Order(TALISKER, 50);

            //exercise
            order.fill(warehouse);

            //verify
            Assert.IsTrue(order.isFilled);
            Assert.AreEqual(0, warehouse.getInventory(TALISKER));
        }

        [TestMethod]
        public void testOrderDoesNotRemoveIfNotEnough()
        {
            //setup - data
            Order order = new Order(TALISKER, 51);
            
            //exercise
            order.fill(warehouse);

            //verify
            Assert.IsFalse(order.isFilled);
            Assert.AreEqual(50, warehouse.getInventory(TALISKER));
        }
    }
}
