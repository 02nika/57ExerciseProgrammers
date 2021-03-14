using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_44
{
    public class PrintInfoFromJson
    {
        /*
         * აღნიშნული მეთოდი იღებს ერთ მისამართს.
         * ამ მისამართიდან მოაქვს ჯეისონის ფაილი და პრინტავს ბოლო ელემენტს.
         * რატომ ბოლო ელემენტს? 
         * იმიტომ, რომ ბოლო ელემენტია ზუსტად ის რისი გამოტანაც გვინდა.
        */
        public static void PrintInfo(string address)
        {
            dynamic jsonObject = JObject.Parse(File.ReadAllText(address));
            var result = jsonObject.products[jsonObject.products.Count - 1];
            Console.WriteLine("Name: " + result.Name);
            Console.WriteLine("Price: " + result.Price.ToString("C", new System.Globalization.CultureInfo("en-US")));
            Console.WriteLine("Quantity on hand: " + result.Quantity);
        }
    }
}
