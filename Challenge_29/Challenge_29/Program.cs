using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_29
{
    class Program
    {
        public static void RoleOf72(string number)
        {
            double years;
            while (true) 
            {
                try
                {
                    if (number.All(char.IsLetter))
                    {
                        Console.WriteLine("Sorry. That's not a valid input.");
                        Console.Write("enter r: ");
                        number = Console.ReadLine();
                    }
                    int.TryParse(number, out int num1);
                    years = 72 / num1;
                    Console.WriteLine("It will take " + Math.Round(years, 2) + " years to double your initial investment.");
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("u divide by zero  \n");
                    Console.Write("enter r: ");
                    number = Console.ReadLine();
                }
            }

        }
        static void Main(string[] args)
        {
            Console.Write("enter r: ");
            string text1 = Console.ReadLine();
            RoleOf72(text1);
            Console.ReadLine();
        }
    }
}
