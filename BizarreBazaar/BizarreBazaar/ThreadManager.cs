using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BizarreBazaar {
    class ThreadManager {
        static public List<Shop> shopList;
        static private int maxShops = 2;

        static public List<Customer> custList;
        static private int maxCustomers = 2;

        private ThreadManager() { }

        private static void Stock(Shop shop)
        {
            while (shop.itemCount < 20) {
                Item item = (Item)Factory.Create(MarketRole.ITEM);
                Console.WriteLine("{0} is being pushed into {1} stack.", item.itemName, shop.shopName);
                shop.stack.Push(item);
                shop.itemCount++;
                System.Threading.Thread.Sleep(200);
            }
        }

        private static void Buy(Customer cust, Shop shop)
        {
            int count = 0;

            lock (shop) {
                while (count < 20) {
                    if (shop.stack.Count != 0) {
                        Item item = shop.stack.Peek();
                        Console.WriteLine("Customer {0} is removing {1} from the {2} stack.", cust.customerName, item.itemName, shop.shopName);
                        shop.stack.Pop();
                        count++;
                    }
                    System.Threading.Thread.Sleep(200);
                }
            }
        }

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

            foreach (Shop shop in shopList) {
                Thread th = new Thread(() => Stock(shop));
                th.Start();
                foreach (Customer cust in custList) {
                    th = new Thread(() => Buy(cust, shop));
                    th.Start();
                }
            }

            
        }
    }
}
