using System;

namespace BizarreBazaar {
    class Client {
        static void Main()
        {
            // Initialiserer trådene
            ThreadManager threads = new ThreadManager(3, 2, 20);
            threads.Initialize();

            // Brukt for å pause konsollen
            Console.ReadKey();
        }
    }
}
