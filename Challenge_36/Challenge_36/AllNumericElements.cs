using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_36
{
    static class AllNumericElements
    {
        public static List<int> EnterAllNumbers(this List<int> array1)
        {
            string readInput = Console.ReadLine();
            while (readInput.Any() && readInput != "done")
            {
                array1.Add(int.Parse(readInput));
                Console.Write("Enter a number: ");
                readInput = Console.ReadLine();
            }
            return array1;
        }
        public static void OutputNumbers(this List<int> array1)
        {
            Console.WriteLine("Numbers: " + string.Join(", ", array1));
            Console.WriteLine();
        }
    }
}
