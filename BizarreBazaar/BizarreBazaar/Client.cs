using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BizarreBazaar {
    class Client {
        static void Main()
        {
            int maxItems = 20;
            int count = 0;

            while (count < maxItems) {
                ThreadManager.InitializeThreads();

                //shop.PrintInventory();

                //ThreadManager.BuyWare(shop, item);

                //shop.PrintInventory();
                count++;
            }

            Console.ReadKey();
        }
    }
}
