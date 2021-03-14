using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_37
{
    class NumberGenerator
    {
        public static List<int> GetNumbers(int capacity)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < capacity; i++)
            {
                list.Add(rand.Next(0, 9));
            }
            return list;
        }
    }
}
