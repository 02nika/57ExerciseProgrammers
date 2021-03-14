using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Challenge_44
{
    class Program
    {

        static void Main(string[] args)
        {
            //ჯეისონ ფაილის მისამართი
            string address = @"D:\nika\c#\Challenge_57\Challenge_44\Challenge_44\dataa.json";
            //დინამიკ ცვლადში ვინახავთ ფაილს, რომელიც გაიპარსება ჯეისონ ფორმატში.
            dynamic jsonObject = JObject.Parse(File.ReadAllText(address));


            Console.Write("What is the product name? ");
            string name = Console.ReadLine();

            //ეძებს სახელის მიხედვით ჯეისონში არსებულ პროდუქტს, თუ პროდუქტის სახელი დაემთხვა დააბრუნებს true-ს
            bool result = GetInfoFromJson.JsonGetValue(jsonObject, name);

            //false-ის შემთხვევაში ეკითხება დამატებით კითხვებს
            GetInfoFromJson.OtherQuestion(result, jsonObject, name, address);

            Console.ReadKey();
        }
    }
}
