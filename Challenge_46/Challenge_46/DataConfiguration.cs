using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_46
{
    public class DataConfiguration
    {
        public static Dictionary<string,int> ArrayToDict(string[] array)
        {
            Dictionary<string, int> newDict = new Dictionary<string, int>();
            for (int i = 0; i < array.Length; i++)
            {
                string word = array[i];
                if (!char.IsLetterOrDigit(word[word.Length - 1]))
                    word = word.Remove(word.Length - 1);

                if (newDict.ContainsKey(word))
                    newDict[word]++;
                else
                    newDict.Add(word, 1);
            }
            return newDict;
        }
    }
}
