using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_44
{
    public class WorkingWithJson
    {
        /*
         * აღნიშნული მეთოდი გადაცემულ ლისტს აკონვერტირებს ჯეისონის ფაილად 
         * და ანთავსებს გადაცემულ ლოკაციაზე.
        */
        public static void WriteListToJsonFile(string address, List<Product> productsList)
        {
            Dictionary<string, List<Product>> result = new Dictionary<string, List<Product>>();
            result.Add("products", productsList);

            string json = JsonConvert.SerializeObject(result);
            File.WriteAllText(address, json);

        }
    }
}
