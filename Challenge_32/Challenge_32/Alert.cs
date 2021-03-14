using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_32
{
    class Alert
    {
        public static int CheckNumber(int min, int number, int max)
        {
            if(!(number<min) || !(number>max))
            {
                Console.Write("enter the number inside the range: ");
                int number2 = int.Parse(Console.ReadLine());
                return CheckNumber(min, number2, max);
            }
            return number;
        }
    }
}
