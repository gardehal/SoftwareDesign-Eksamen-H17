using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    public class Shop {
        public string shopName { get; set; }
        public int itemCount { get; set; }
        public List<Item> inventoryList;
        public Item[] inventory;
        public int inventorySize { get { return inventoryList.Count(); } }

        private Shop()
        {
            this.shopName = "";
            this.itemCount = 0;
            inventoryList = new List<Item>();
            inventory = new Item[20];
        }

        public Shop(string shopName)
        {
            this.shopName = shopName;
            inventoryList = new List<Item>();
            inventory = new Item[20];
        }

        public void AddItem(Item item)
        {
            inventoryList.Add(item);
        }

        public bool RemoveItem(Item item)
        {
            if (inventoryList.Contains(item) != false) {
                inventoryList.Remove(item);
                return true;
            }

            return false;
        }

        public void RemoveItemAtIndex(int item)
        {
            inventoryList.RemoveAt(item);
        }

        public void PrintInventory()
        {
            Console.WriteLine("Current stock is {0}", inventorySize);
            foreach (Item i in inventoryList) {
                Console.WriteLine("item #{0}: {1}", inventoryList.IndexOf(i) + 1, i.itemName);
            }
        }
    }
}
