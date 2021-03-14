using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_41
{
    public static class GetBiggestlength
    {
        public static int GetBiggest(this IEnumerable<string> list)
        {
            int length = 0;
            foreach (string item in list)
            {
                if (length < item.Length)
                    length = item.Length;
            }
            return length;
        }
    }
}
