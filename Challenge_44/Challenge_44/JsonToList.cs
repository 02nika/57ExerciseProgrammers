using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_44
{
    public class JsonToList
    {
        /*
         ეს მეთოდი გადაცემულ ჯეისონის ფაილს პარსავს და ინახავს ახლად შექმნილ პროდუქტების ლისტში.
         */
        public static List<Product> ConvertListOfProducts(dynamic json)
        {
            List<Product> products = new List<Product>();
            int count = 0;
            while (json.products.Count > count)
            {
                products.Add(new Product() 
                {
                    Name = json.products[count].Name,
                    Price = json.products[count].Price,
                    Quantity = json.products[count].Quantity,
                });
                count++;
            }
            
            return products;

        }
    }
}
