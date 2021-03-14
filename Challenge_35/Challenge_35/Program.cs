using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_35
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList list1 = NameList.EnterNames();
            string winner = list1.GetRandomString();

            Console.WriteLine("The winner is... " + winner + ".");
            list1 = list1.SetWinner(winner);
            winner = list1.GetRandomString();
            Console.WriteLine("The Second Place goes To... " + winner + ".");
            Console.ReadLine();
        }
    }
}
