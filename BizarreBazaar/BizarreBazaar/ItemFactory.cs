using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    // enum for å sjekke hvilke type item det er
    enum ItemType { FOOD, DRINK, TOY, CLOTHING, FURNITURE }

    class ItemFactory {
        private ItemFactory() { }

        public static Item Create(ItemType type)
        {
            Item item = null;
            string name, desc1, desc2;

            // Henter fram navn og beskrivelser fra StringGenerator
            name = StringGenerator.GetItemName(type);
            desc1 = StringGenerator.GetItemDescription(type);
            desc2 = StringGenerator.GetItemDescription(type);

            // Kan ikke ha samme beskrivelse, så sørger for at det ikke skjer
            while (desc1 == desc2) {
                desc2 = StringGenerator.GetItemDescription(type);
            }

            // Setter nytt item-objekt og returnerer det
            item = new Item(name, desc1, desc2);

            return item;
        }
    }
}
