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
            ThreadManager.InitializeThreads();

            Console.ReadKey();
        }
    }
}
