using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_47
{
    class OutPutJson
    {
        public static void PrintResult(string jsonInString)
        {
            dynamic dynamJson = JObject.Parse(jsonInString);

            //
            Dictionary<dynamic, dynamic> mainDict = new Dictionary<dynamic, dynamic>();
            //
            Console.WriteLine("with columns: \n\n\n");

            Console.WriteLine("Name                  | Craft");
            Console.WriteLine("----------------------|--------");
            foreach (var item in dynamJson.people)
            {
                mainDict.Add(item.name, item.craft);
            }


            int max = MaxValue(mainDict);

            foreach (var item2 in mainDict.OrderBy(x => x.Key))
            {
                Console.WriteLine(string.Format($"{{0, {-max - 1}}} | {{1}}",
                        item2.Key, item2.Value));
            }

            Console.WriteLine("with grouping: \n\n\n");
            var dict1 = mainDict.GroupBy(x => x.Value);
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key + " : ");
                foreach (var element in item.OrderBy(x => x.Key))
                {
                    Console.WriteLine("     " + element.Key + " " + element.Value);
                }
            }
        }

        private static int MaxValue(Dictionary<dynamic, dynamic> test1)
        {
            int max = 0;
            string value;
            foreach (var item in test1)
            {
                value = Convert.ToString(item.Key);
                if (max < value.Length)
                    max = value.Length;
            }
            return max;
        }
    }
}
