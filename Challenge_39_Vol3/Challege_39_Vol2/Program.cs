using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challege_39_Vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new FirstTryDatabaseEntities();
            foreach (var item in result.Employees)
            {
                Console.WriteLine(item.First_Name);
                Console.WriteLine(item.Last_Name);
            }

            Console.ReadLine();
        }
    }
}
