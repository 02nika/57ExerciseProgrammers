using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_35
{
    class NameList
    {
        public static ArrayList EnterNames()
        {

            ArrayList list = new ArrayList();
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            while (name.Length != 0)
            {
                list.Add(name);
                Console.Write("Enter a name: ");
                name = Console.ReadLine();
            }
            return list;
        }
    }
}
