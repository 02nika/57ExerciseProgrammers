using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_35
{
    static class RandomFromArrayList
    {
        public static string GetRandomString(this ArrayList arrayList)
        {
            Random rand = new Random();
            int randInt = rand.Next(arrayList.Count);
            return (string)arrayList[randInt];
        }
    }
}
