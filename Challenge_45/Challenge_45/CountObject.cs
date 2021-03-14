using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_45
{
    public class CountObject
    {
        public static int CountString(string data, string word)
        {
            char[] symbols = word.ToCharArray();
            int symbolsInt = 0;
            int count = 0;
            data.Contains(word);
            for (int i = 0; i < data.Length; i++)
            {
                if(symbolsInt == symbols.Length)
                {
                    count++;
                    symbolsInt = 0;
                }
                if(data[i] == symbols[symbolsInt])
                {
                    symbolsInt++;
                }
            }
            return count;
        }
    }
}
