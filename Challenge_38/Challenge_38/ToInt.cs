using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_38
{
    static class ToInt
    {
        public static IEnumerable<int> FilterEvenNumbers(this string[] strings)
        {
            foreach (var item in strings)
            {
                if (int.TryParse(item, out int number))
                {
                    if (number % 2 == 0)
                        yield return number;
                }
            }
        }
    }
}
