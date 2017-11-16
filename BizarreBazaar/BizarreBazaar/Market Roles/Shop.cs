using System.Collections.Generic;

namespace BizarreBazaar {
    public class Shop {
        public string shopName { get; set; }
        public int itemsStocked { get; set; }
        public int itemsSold { get; set; }
        private Stack<Item> inventoryStack;

        public int inventorySize { get { return inventoryStack.Count; } }

        private Shop()
        {
            this.shopName = "";
            this.itemsStocked = 0;
            this.itemsSold = 0;
            inventoryStack = new Stack<Item>();
        }

        public Shop(string shopName)
        {
            this.shopName = shopName;
            this.itemsStocked = 0;
            this.itemsSold = 0;
            inventoryStack = new Stack<Item>();
        }

        public void AddItem(Item item)
        {
            inventoryStack.Push(item);
            itemsStocked++;
        }

        public void RemoveItem()
        {
            if (inventorySize != 0) {
                inventoryStack.Pop();
                itemsSold++;
            }
        }

        public Item CheckRecentItem()
        {
            return inventoryStack.Pop();
        }
    }
}
