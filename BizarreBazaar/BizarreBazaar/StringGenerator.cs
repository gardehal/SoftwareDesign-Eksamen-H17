using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    enum ItemType { FOOD, DRINK, TOY, CLOTHING, FURNITURE }

    class StringGenerator {

        static private Random ranNum = new Random();

        private StringGenerator() { }

        // Metode for å skaffe item navn
        public static string GetName (MarketRole role)
        {
            List<string> stringList = new List<string>();

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
            } else if (role == MarketRole.SHOP) {
                stringList.Add("Super cool shop");
                stringList.Add("Super duper emporium shop");
                stringList.Add("Starbucks");
                stringList.Add("Amazing fantastical shop");
            } else if (role == MarketRole.CUSTOMER) {
                stringList.Add("Per");
                stringList.Add("Bob");
                stringList.Add("Jessica");
                stringList.Add("Alex");
                stringList.Add("Alexander");
                stringList.Add("Margrethe");
            }

            // Setter index til random for å få et random indeks av stringList
            int index = ranNum.Next(stringList.Count);
            string name = stringList[index];

            return name;
        }
    }
}
