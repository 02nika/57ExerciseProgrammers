using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Challenge_37
{
    static class ArrayListIntoString
    {
        // ArrayList გადაყავს სტრინგში
        public static string MyToString(this ArrayList mainList)
        {
            string returnString = "";
            foreach (var item in mainList)
            {
                returnString += item.ToString();
            }
            return returnString;
        }
    }
}
