using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Challenge_46
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllText("data.txt").ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict1 = DataConfiguration.ArrayToDict(data);

            foreach (var item in dict1.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(string.Format("{0,8}:  {1}", item.Key, new string('*' , item.Value)));
            }

            Console.ReadKey();
        }
    }
}
