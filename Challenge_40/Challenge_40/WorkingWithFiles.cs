using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_40
{
    public static class WorkingWithFiles
    {
        public static List<Employees> TxtToList(this IEnumerable<string> allLines)
        {
            List<Employees> list1 = new List<Employees>();
            foreach (string item in allLines)
            {
                list1 = AddItem(list1, item.Split(' ').ToArray());
            }
            return list1;
        }

        private static List<Employees> AddItem(List<Employees> list1, string[] lineOfData)
        {
            list1.Add(new Employees() { firstName = lineOfData[0], lastName = lineOfData[1],
                                        Position = lineOfData[2]});
            return list1;
        }
    }
}
