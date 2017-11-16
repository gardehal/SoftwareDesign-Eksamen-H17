using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizarreBazaar;

namespace BizarreBazaarTestUnit {
    [TestClass]
    public class ItemTest {
        [TestMethod]
        public void TestItem()
        {
            Item item = new Item("Per");

            Assert.AreEqual(item.itemName, "Per");
        }

        [TestMethod]
        public void TestItemIsNull()
        {
            Item item = null;

            Assert.AreEqual(item, null);
        }
    }
}
