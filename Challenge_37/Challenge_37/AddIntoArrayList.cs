using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_37
{
    static class AddIntoArrayList
    {
        /*
        პირველ მასივში წერს მეორე მასივის ელემენტებს 
        */
        public static ArrayList AddValues<T>(this ArrayList mainList, List<T> OtherList)
        {
            foreach (T item in OtherList)
            {
                mainList.Add(item);
            }
            return mainList;
        }
    }
}
