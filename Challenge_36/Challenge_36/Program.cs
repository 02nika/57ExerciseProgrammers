using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            List<int> list1 = new List<int>();
            list1.EnterAllNumbers();
            list1.OutputNumbers();
            Console.WriteLine("The average is " + list1.GetAVG() + ".");
            Console.WriteLine("The minimum is " + list1.GetMin() + ".");
            Console.WriteLine("The maximum is " + list1.GetMax() + ".");
            Console.WriteLine("The standard deviation is " + list1.GetDeviation() + " .");

            Console.ReadLine();
        }
    }
}
