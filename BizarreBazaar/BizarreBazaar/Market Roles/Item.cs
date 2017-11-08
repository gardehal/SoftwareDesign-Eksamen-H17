using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    public class Item {
        private string itemName;

        private Item()
        {
            this.itemName = "";
        }

        public Item(string itemName)
        {
            this.itemName = itemName;
        }

        public string GetName()
        {
            return itemName;
        }

        public void SetName(string itemName)
        {
            this.itemName = itemName;
        }
    }
}
