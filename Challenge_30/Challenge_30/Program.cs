using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_30
{
    class Program
    {
        public static int[,] Multiplicate(int first, int second)
        {
            int[,] arr1 = new int[first, second];
            for (int i = 1; i < first; i++)
            {
                for (int j = 1; j < second; j++)
                {
                    arr1[i, j] = j * i;
                }
            }
            return arr1;
        }
        static void Main(string[] args)
        {
            Console.Write("enter first number: ");
            int.TryParse(Console.ReadLine(), out int first);

            Console.Write("enter second number: ");
            int.TryParse(Console.ReadLine(), out int second);

            int[,] array1 = Multiplicate(first+1, second+1);

            for (int i = 1; i < array1.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 1; j < array1.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0, -5}", array1[i, j]));
                }
            }
            Console.ReadLine();
        }
    }
}
