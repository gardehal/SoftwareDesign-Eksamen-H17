using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizarreBazaar;

namespace BizarreBazaarTestUnit {
    [TestClass]
    public class TestUnit {
        // Factory tester
        [TestMethod]
        public void TestFactory()
        {
            Item item = (Item)Factory.Create(MarketRole.ITEM);
            Shop shop = (Shop)Factory.Create(MarketRole.SHOP);
            Customer customer = (Customer)Factory.Create(MarketRole.CUSTOMER);

            Assert.IsNotNull(item);
            Assert.IsNotNull(shop);
            Assert.IsNotNull(customer);
        }

        // Shop tester
        [TestMethod]
        public void TestAddToShop()
        {
            Shop shop = (Shop)Factory.Create(MarketRole.SHOP);

            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));

            Assert.AreEqual(1, shop.inventorySize);
        }

        [TestMethod]
        public void TestAdd5ToShop()
        {
            Shop shop = (Shop)Factory.Create(MarketRole.SHOP);

            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));

            Assert.AreEqual(5, shop.inventorySize);
        }

        [TestMethod]
        public void TestAddAndRemoveFromShop()
        {
            Shop shop = (Shop)Factory.Create(MarketRole.SHOP);

            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));
            shop.AddItem((Item)Factory.Create(MarketRole.ITEM));

            Assert.AreEqual(5, shop.inventorySize);

            shop.RemoveItem();
            shop.RemoveItem();
            shop.RemoveItem();

            Assert.AreEqual(2, shop.inventorySize);
        }

        [TestMethod]
        public void TestCheckRecentlyAddedItem()
        {
            Shop shop = (Shop)Factory.Create(MarketRole.SHOP);

            Item item = (Item)Factory.Create(MarketRole.ITEM);

            shop.AddItem(item);

            Assert.AreEqual(item, shop.CheckRecentlyAddedItem());
        }

        // String Generator tester
        [TestMethod]
        public void TestStringGeneratorIsNotNull()
        {
            string itemName = StringGenerator.GetName(MarketRole.ITEM);
            string shopName = StringGenerator.GetName(MarketRole.SHOP);
            string customerName = StringGenerator.GetName(MarketRole.CUSTOMER);

            Assert.IsNotNull(itemName);
            Assert.IsNotNull(shopName);
            Assert.IsNotNull(customerName);
        }

        [TestMethod]
        public void TestStringGeneratorOccurances()
        {
            List<string> stringList = new List<string>();

            for (int i = 0; i < 100; i++) {
                stringList.Add(StringGenerator.GetName(MarketRole.CUSTOMER));
            }

            int occurances = 0;

            for (int i = 0; i < stringList.Count; i++) {
                if (stringList[i] == "Per") {
                    occurances++;
                }
            }

            // Sjekker at navnet dukker opp i gjennomsnitt mindre enn 15 ganger
            Assert.IsTrue(occurances < 15);
        }
    }
}
