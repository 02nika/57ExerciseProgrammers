using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Challenge_44
{
    public class AddElement
    {
        /*
         * თუ მომხმარებელს ახალი მონაცემის დამატება უნდა ეს მეთოდი გამოიძახება,
         * სადაც უკვე მომხმარებელმა უნდა შეიყვანოს ფასი და რაოდენობა, (სახელი უკვე ცნობილია ჩვენთვის).
         * ჯეისონში არსებულ ინფორმაციას ვინახავთ ლისტში და შემდეგ ვამატებთ ერთ ახალ მონაცემს.
         * შემდეგ კი ხორციელდება გადაწერა ჯეისონის ფაილზე განახლებული ლისტით, 
        */
        public static void AddNewProduct(string name, dynamic info, string address)
        {
            Console.Write("\nenter price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("enter quantity : ");
            int quantity = int.Parse(Console.ReadLine());

            //პროდუქტების ლისტში ვწერთ ჯეისონის ინფორმაციას.
            List<Product> products = JsonToList.ConvertListOfProducts(info);
            products.Add(new Product()
            {
                Name = name,
                Price = price,
                Quantity = quantity
            });

            //გადაცემულს პროდუქტების ლისტს ვინახავთ ჯეისონის ფაილში, გადაცემულ მისამართზე.
            WorkingWithJson.WriteListToJsonFile(address, products);

            Console.WriteLine("wait for few seconds...");
            Thread.Sleep(1200);
            Console.WriteLine("product Added...\n");
            PrintInfoFromJson.PrintInfo(address);
        }

    }
}
