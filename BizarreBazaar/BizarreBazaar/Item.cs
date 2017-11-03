using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    class Item {
        private string itemName;
        private string itemDesc1;
        private string itemDesc2;

        public Item()
        {
            this.itemName = "";
            this.itemDesc1 = "";
            this.itemDesc2 = "";
        }

        public Item(string itemName, string itemDesc1, string itemDesc2)
        {
            this.itemName = itemName;
            this.itemDesc1 = itemDesc1;
            this.itemDesc2 = itemDesc2;
        }

        public string GetName()
        {
            return itemName;
        }

        public void SetName(string itemName)
        {
            this.itemName = itemName;
        }

        public string GetItemDesc(int i)
        {
            if(i == 1) {
                return itemDesc1;
            } else if(i == 2) {
                return itemDesc2;
            }

            return null;
        }

        public void SetItemDesc(int i, string desc)
        {
            if (i == 1) {
                itemDesc1 = desc;
            } else if (i == 2) {
                itemDesc2 = desc;
            }
        }
    }
}
