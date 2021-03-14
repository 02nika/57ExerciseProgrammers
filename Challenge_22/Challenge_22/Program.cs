using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many number Do you want: ");
            int numbersCount = Convert.ToInt32(Console.ReadLine());
            int number;
            int[] numbers = new int[numbersCount];
            for (int i = 1; i <= numbersCount; i++)
            {
                Console.Write("enter number: ");
                number = Convert.ToInt32(Console.ReadLine());
                numbers[i - 1] = number;
            }
            if(DifferantOrNot.CheckDifferance(numbers))
                FindBiggestNumber(numbers);

            Console.ReadLine();

        }

        private static void FindBiggestNumber(int[] array1)
        {
            
            int biggest = -1;
            foreach (int num in array1)
            {
                if (num > biggest)
                    biggest = num;
            }
            Console.WriteLine("The largest number is " + biggest);
        }
    }
}
