using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizarreBazaar {
    class StringGenerator {

        static private Random ranNum = new Random();

        private StringGenerator() { }

        // Metode for å skaffe item navn
        public static string GetItemName (ItemType type)
        {
            List<string> stringList = new List<string>();

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

            // Setter index til random for å få et random indeks av stringList
            int index = ranNum.Next(stringList.Count);
            string name = stringList[index];

            return name;
        }

        // Metode for å hente item beskrivelse
        public static string GetItemDescription(ItemType type)
        {
            List<string> stringList = new List<string>();

            // switch-case for type for å sørge for at beskrivelsen passer typen
            switch (type) {
                case ItemType.CLOTHING:
                    stringList.Add("fuzzy");
                    stringList.Add("warm");
                    stringList.Add("comfy");
                    stringList.Add("a bit too big");
                    break;
                case ItemType.DRINK:
                    stringList.Add("cold");
                    stringList.Add("nice");
                    stringList.Add("refreshing");
                    stringList.Add("enjoyable");
                    break;
                case ItemType.FOOD:
                    stringList.Add("tasty");
                    stringList.Add("juicy");
                    stringList.Add("delicious");
                    stringList.Add("spicy");
                    break;
                case ItemType.FURNITURE:
                    stringList.Add("wooden");
                    stringList.Add("ancient markings");
                    stringList.Add("hidden artefacts");
                    stringList.Add("glossy");
                    break;
                case ItemType.TOY:
                    stringList.Add("fuzzy");
                    stringList.Add("fun to play with");
                    stringList.Add("awesome");
                    stringList.Add("wooden");
                    break;
            }

            // Setter index til random for å få et random indeks av stringList
            int index = ranNum.Next(stringList.Count);
            string name = stringList[index];

            return name;
        }
    }
}
