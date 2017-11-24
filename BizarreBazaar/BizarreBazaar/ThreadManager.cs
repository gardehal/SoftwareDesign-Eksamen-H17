using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BizarreBazaar {
    public class ThreadManager {
        // Shop variabler og antall shops
        private List<Shop> shopList;
        private int maxShops;

        // Customer variabler og antall kunder
        private List<Customer> custList;
        private int maxCustomers;

        // Maks antall varer som skal bli solgt
        private int maxItems;

        // Objekt brukt til å locke tråder
        private Object _lock = new Object();

        public ThreadManager(int maxShops, int maxCustomers, int maxItems) {
            this.maxShops = maxShops;
            this.maxCustomers = maxCustomers;
            this.maxItems = maxItems;
        }

        // Funksjon til å legge til ny vare
        private void Stock (Shop shop)
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
        private void Buy (Customer cust, Shop shop)
        {
            while (shop.itemsSold < maxItems) {
                lock (_lock) {
                    if (shop.inventorySize != 0) {
                        Item item = shop.CheckRecentlyAddedItem();
                        Console.WriteLine("                                                      " +
                            "{0} bought {1} from {2}'s inventory.", cust.customerName, item.itemName, shop.shopName);
                        shop.RemoveItem();
                    }
                }
            }
        }

        // Initialiserer listene og trådene
        public void Initialize()
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
