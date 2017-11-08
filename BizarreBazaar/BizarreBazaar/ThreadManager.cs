using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BizarreBazaar {
    class ThreadManager {
        public static List<Shop> shopList;
        public static List<Customer> customerList;

        public static int maxShops = 2;
        public static int maxCustomers = 3;

        private ThreadManager() { }

        public static void StockWare(Shop shop, Item item)
        {
            shop.AddItem(item);
            Console.WriteLine("{0} added item #{1}", shop.GetName(), shop.GetInventorySize());
        }

        public static void BuyWare(Customer customer, Shop shop, Item item)
        {
            if (shop.GetInventorySize() != 0) {
                Console.WriteLine("Item #{0} from {1} was bought by {2}", shop.inventoryList.IndexOf(item) + 1, shop.GetName(), customer.GetName());
                shop.RemoveItem(item);
            }
        }

        public static void InitializeThreads()
        {
            shopList = new List<Shop>();
            while (shopList.Count() < maxShops) {
                Shop shop = (Shop)Factory.Create(MarketRole.SHOP);
                shopList.Add(shop);
            }

            customerList = new List<Customer>();
            while (customerList.Count() < maxCustomers) {
                Customer customer = (Customer)Factory.Create(MarketRole.CUSTOMER);
                customerList.Add(customer);
            }

            foreach (Shop shop in shopList) {
                Item item = (Item)Factory.Create(MarketRole.ITEM);
                Thread th = new Thread(() => StockWare(shop, item));
                th.Start();
            }

            /*foreach (Customer cust in customerList) {
                Thread th = new Thread(() => BuyWare());
                th.Start();
            }*/
        }
    }
}
