using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    public class Shop {
        private string shopName;
        public List<Item> inventoryList;

        private Shop()
        {
            this.shopName = "";
            inventoryList = new List<Item>();
        }

        public Shop(string shopName)
        {
            this.shopName = shopName;
            inventoryList = new List<Item>();
        }

        public string GetName()
        {
            return shopName;
        }

        public void SetName(string shopName)
        {
            this.shopName = shopName;
        }

        public void AddItem(Item item)
        {
            inventoryList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            inventoryList.Remove(item);
        }

        public int GetInventorySize()
        {
            return inventoryList.Count;
        }

        public void PrintInventory()
        {
            Console.WriteLine("Current stock is {0}", GetInventorySize());
            foreach (Item i in inventoryList) {
                Console.WriteLine("item #{0}: {1}", inventoryList.IndexOf(i) + 1, i.GetName());
            }
        }
    }
}
