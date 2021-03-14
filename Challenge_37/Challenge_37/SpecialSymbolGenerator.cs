using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_37
{
    class SpecialSymbolGenerator
    {
        public static List<char> GetSpecialList(int capacity)
        {
            string specialChars = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            Random rand = new Random();
            int symbolInt;
            List<char> returnList = new List<char>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                symbolInt = rand.Next(specialChars.Length);
                returnList.Add(specialChars[symbolInt]);
            }
            return returnList;
        }
    }
}
