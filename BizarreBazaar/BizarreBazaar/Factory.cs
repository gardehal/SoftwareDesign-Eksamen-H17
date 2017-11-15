using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    // enum for å sjekke hvilke type item det er
    enum MarketRole { ITEM, SHOP, CUSTOMER }

    class Factory {
        private Factory() { }

        public static object Create (MarketRole role)
        {
            if (role == MarketRole.ITEM) {
                Item item = null;
                string name;

                // Henter fram navn og beskrivelser fra StringGenerator
                name = StringGenerator.GetName(MarketRole.ITEM);

                // Setter nytt item-objekt og returnerer det
                item = new Item(name);

                return item;
            } else if (role == MarketRole.SHOP) {
                Shop shop = null;
                string name;

                // Henter fram navn og beskrivelser fra StringGenerator
                name = StringGenerator.GetName(MarketRole.SHOP);

                // Setter nytt item-objekt og returnerer det
                shop = new Shop(name);

                return shop;
            } else if (role == MarketRole.CUSTOMER) {
                Customer customer = null;
                string name;

                // Henter fram navn og beskrivelser fra StringGenerator
                name = StringGenerator.GetName(MarketRole.CUSTOMER);

                // Setter nytt item-objekt og returnerer det
                customer = new Customer(name);

                return customer;
            }

            return null;
        }
    }
}
