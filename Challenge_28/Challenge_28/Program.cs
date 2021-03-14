using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_28
{
    static class Program
    {
        public static void IteratingByHuman(int count, List<int> arr1)
        {
            int number;
            while (count > 0)
            {
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out number);
                arr1.AppendNumber(number);
                count--;
            }
        }
        public static int Sum(this List<int> list1)
        {
            int sum=0;
            foreach (int item in list1)
            {
                sum += item;
            }
            return sum;
        }
        private static List<int> AppendNumber(this List<int> list1, int number)
        {
            list1.Add(number);
            return list1;
        }
        static void Main(string[] args)
        {
            List<int> arr1 = new List<int>{ };
            Console.Write("how many numbers do you want: ");
            int.TryParse(Console.ReadLine(), out int count);
            IteratingByHuman(count, arr1);

            Console.WriteLine("The total is " + arr1.Sum());
            Console.ReadLine();
        }
    }
}
