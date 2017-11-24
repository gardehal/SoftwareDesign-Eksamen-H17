namespace BizarreBazaar {
    // enum for å sjekke hvilke type item det er
    public enum MarketRole { ITEM, SHOP, CUSTOMER }

    public class Factory {
        private Factory() { }

        // HUSK: Må caste Create() til riktig objekt-type, f.eks hvis du vil ha item: (Item)Factory.Create(MarketRole.ITEM);
        public static object Create (MarketRole role)
        {
            // Factory for vare
            if (role == MarketRole.ITEM) {
                Item item = null;
                string name;

                // Henter fram navn og beskrivelser fra StringGenerator
                name = StringGenerator.GetName(MarketRole.ITEM);

                // Setter nytt item-objekt og returnerer det
                item = new Item(name);

                return item;
            // Factory for shop
            } else if (role == MarketRole.SHOP) {
                Shop shop = null;
                string name;

                // Henter fram navn og beskrivelser fra StringGenerator
                name = StringGenerator.GetName(MarketRole.SHOP);

                // Setter nytt item-objekt og returnerer det
                shop = new Shop(name);

                return shop;
            // Factory for kunde
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
