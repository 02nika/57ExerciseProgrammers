using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_41
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> data = File.ReadAllLines("data.txt");
            data = data.OrderBy(x => x);
            Console.WriteLine("Total of " + data.MyGetLength() +  " names");
            Console.WriteLine(new string('-', data.GetBiggest()));
            foreach (string item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
