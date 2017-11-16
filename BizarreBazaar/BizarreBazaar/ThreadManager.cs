using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BizarreBazaar {
    class ThreadManager {
        // Shop variabler og antall shops
        static private List<Shop> shopList;
        static private int maxShops = 4;

        // Customer variabler og antall kunder
        static private List<Customer> custList;
        static private int maxCustomers = 8;

        // Maks antall varer som skal bli solgt
        static private int maxItems = 20;

        // Objekt brukt til å locke tråder
        static private Object _lock = new Object();

        private ThreadManager() { }

        // Legge til ny vare
        private static void Stock (Shop shop)
        {
            while (shop.itemsStocked < maxItems) {
                lock (_lock) {
                    Item item = (Item)Factory.Create(MarketRole.ITEM);
                    Console.WriteLine("Item #{0}: {1} is added to {2}'s inventory.", shop.itemsStocked + 1, item.itemName, shop.shopName);
                    shop.AddItem(item);
                    System.Threading.Thread.Sleep(300);
                }
            }
        }

        // Kunde kjøper vare
        private static void Buy (Customer cust, Shop shop)
        {
            while (shop.itemsSold < maxItems) {
                lock (_lock) {
                    if (shop.inventorySize != 0) {
                        Item item = shop.CheckRecentItem();
                        Console.WriteLine("                                                      " +
                            "{0} bought {1} from {2}'s inventory.", cust.customerName, item.itemName, shop.shopName);
                        shop.RemoveItem();
                    }
                }
            }
        }

        // Initialiserer listene og trådene
        public static void InitializeThreads()
        {
            shopList = new List<Shop>();
            custList = new List<Customer>();

            while (shopList.Count() < maxShops) {
                shopList.Add((Shop)Factory.Create(MarketRole.SHOP));
            }

            while (custList.Count() < maxCustomers) {
                custList.Add((Customer)Factory.Create(MarketRole.CUSTOMER));
            }

            foreach (Customer cust in custList) {
                for (int i = 0; i < maxShops - 1; i++) {
                    Thread th = new Thread(() => Buy(cust, shopList[i]));
                    th.Start();
                }
            }

            foreach (Shop shop in shopList) {
                Thread th = new Thread(() => Stock(shop));
                th.Start();
            }
        }
    }
}
