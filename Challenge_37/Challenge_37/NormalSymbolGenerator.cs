using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_37
{
    static class NormalSymbolGenerator
    {
        public static List<char> GetNormalChars(int Mincapacity)
        {
            char symbol;
            Random rand = new Random();
            char[] bigAndSmall = new char[2];
            //password length
            int capacity = GetLength(Mincapacity, rand);
            List<char> returnChar = new List<char>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                bigAndSmall[0] = GetBigSymbol(rand);
                bigAndSmall[1] = GetSmallSymbol(rand);
                symbol = bigAndSmall[rand.Next(2)];
                returnChar.Add(symbol);
            }
            return returnChar;
        }

        private static int GetLength(int mincapacity, Random rand)
        {
            return rand.Next(mincapacity, mincapacity*2);
        }

        private static char GetSmallSymbol(Random rand)
        {
            //Console.WriteLine((int)'a'); //97
            //Console.WriteLine((int)'z'); //122
            return (char)rand.Next(97, 122);
        }

        private static char GetBigSymbol(Random rand)
        {
            //Console.WriteLine((int)'A'); //65
            //Console.WriteLine((int)'Z'); //90
            return (char)rand.Next(65, 90);
        }
    }
}
