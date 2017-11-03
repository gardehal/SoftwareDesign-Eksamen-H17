using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    class Client {
        static void Main()
        {
            List<Item> itemList = new List<Item>();

            itemList.Add(ItemFactory.Create(ItemType.FOOD));
            itemList.Add(ItemFactory.Create(ItemType.DRINK));
            itemList.Add(ItemFactory.Create(ItemType.CLOTHING));

            int itemCount = 1;
            Console.WriteLine("Bought item #{0}, {1}, which happened to be {2} and {3}.", itemCount, itemList[0].GetName(), itemList[0].GetItemDesc(1), itemList[0].GetItemDesc(2));
            itemCount++;
            Console.WriteLine("Bought item #{0}, {1}, that is {2} and {3}.", itemCount, itemList[1].GetName(), itemList[1].GetItemDesc(1), itemList[1].GetItemDesc(2));
            itemCount++;
            Console.WriteLine("Bought item #{0}, {1}, that is {2} and {3}.", itemCount, itemList[2].GetName(), itemList[2].GetItemDesc(1), itemList[2].GetItemDesc(2));

            Console.ReadKey();
        }
    }
}
