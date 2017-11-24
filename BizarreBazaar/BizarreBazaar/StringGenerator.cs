using System;
using System.Collections.Generic;

namespace BizarreBazaar {
    enum ItemType { FOOD, DRINK, TOY, CLOTHING, FURNITURE }

    // StringGenerator blir brukt til å generere tilfeldige navn for de forskjellige klassene
    public class StringGenerator {

        private static Random ranNum = new Random();

        private StringGenerator() { }

        // Metode for å skaffe item navn
        public static string GetName (MarketRole role)
        {
            List<string> stringList = new List<string>();

            // Navn til varer
            if (role == MarketRole.ITEM) {
                Array value = Enum.GetValues(typeof(ItemType));
                ItemType type = (ItemType)value.GetValue(ranNum.Next(value.Length));

                // switch-case for type for å sørge for at navnet passer typen
                switch (type) {
                    case ItemType.CLOTHING:
                        stringList.Add("shoe");
                        stringList.Add("shorts");
                        stringList.Add("shirt");
                        stringList.Add("cap");
                        break;
                    case ItemType.DRINK:
                        stringList.Add("pepsi");
                        stringList.Add("cola");
                        stringList.Add("water");
                        stringList.Add("fanta");
                        break;
                    case ItemType.FOOD:
                        stringList.Add("apple");
                        stringList.Add("lasagne");
                        stringList.Add("taco");
                        stringList.Add("meatballs");
                        break;
                    case ItemType.FURNITURE:
                        stringList.Add("desk");
                        stringList.Add("chair");
                        stringList.Add("sofa");
                        stringList.Add("dinner table");
                        break;
                    case ItemType.TOY:
                        stringList.Add("teddy bear");
                        stringList.Add("toycar");
                        stringList.Add("lego");
                        stringList.Add("action figure");
                        break;
                }
            // Navn til shops
            } else if (role == MarketRole.SHOP) {
                stringList.Add("Cool shop");
                stringList.Add("Super duper emporium");
                stringList.Add("Starbuck");
                stringList.Add("Ebay shop");
                stringList.Add("Amazon shop");
                stringList.Add("Burger King shop");
                stringList.Add("Westerdals shop");
                stringList.Add("Kiwi");
                stringList.Add("Ikea");
            // Navn til customers
            } else if (role == MarketRole.CUSTOMER) {
                stringList.Add("Per");
                stringList.Add("Bob");
                stringList.Add("Jessica");
                stringList.Add("Alex");
                stringList.Add("Alexander");
                stringList.Add("Margrethe");
                stringList.Add("Vincent");
                stringList.Add("Leo");
                stringList.Add("Jay");
                stringList.Add("George");
                stringList.Add("Andrea");
                stringList.Add("Haakon");
                stringList.Add("Bjarne");
            }

            // Setter index til random for å få et random indeks av stringList
            int index = ranNum.Next(stringList.Count);
            string name = stringList[index];

            return name;
        }
    }
}
