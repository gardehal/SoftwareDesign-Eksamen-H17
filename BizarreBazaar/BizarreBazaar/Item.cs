using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    public class Item {
        public string itemName { get; set; }

        private Item()
        {
            this.itemName = "";
        }

        public Item(string itemName)
        {
            this.itemName = itemName;
        }
    }
}
