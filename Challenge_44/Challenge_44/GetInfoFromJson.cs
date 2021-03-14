using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_44
{
    public class GetInfoFromJson
    {
        //ეს მეთოდი აბრუნებს ბულიანს. დააბრუნებს true-ს თუ აღნიშნული პროდუქტის სახელი იპოვა ჯეისონის ფაილში.
        public static bool JsonGetValue(dynamic json, string productName)
        {
            bool seed = false;
            int count = 0;
            while (json.products.Count > count)
            {
                //თუ სახელი დაემთხვევა მეთოდი დაპრინტავს მონაცემებს.
                seed = checkEquality(json.products[count], productName);
                if (seed == true)
                    return seed;
                count++;
            }
            return seed;
        }

        //თუ სახელი დაემთხვევა მეთოდი დაპრინტავს მონაცემებს.
        private static bool checkEquality(dynamic item, string productName)
        {
            if(productName.Equals(item.Name.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Price: " + item.Price);
                Console.WriteLine("Quantity on hand: " + item.Quantity);
                return true;
            }
            return false;
        }
        /*
        იმ შემთხვევაში თუ  JsonGetValue დააბრუნებს false-ს მაშინ ეს მეთოდი იქამდე მოთხოვს პასუხის შეყვანას,
        სანამ სწორად არ შეიყვანს დასახელებას.
        ასევე პროგრამა პარალელურად ეკითხება თუ სურს მსგავსი პროდუქტის დამატება
        */
        public static void OtherQuestion(bool seed, dynamic info, string productName, string address)
        {
            string name;
            while (!seed)
            {
                Console.WriteLine("Sorry, that product was not found in our inventory.");
                Console.Write("Do you want to add Product with This Name? y/n :");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Y)
                {
                    AddElement.AddNewProduct(productName, info, address);
                    break;
                }
                Console.Write("\nWhat is the product name? ");
                name = Console.ReadLine();
                seed = GetInfoFromJson.JsonGetValue(info, name);
            }
        }
    }
}
