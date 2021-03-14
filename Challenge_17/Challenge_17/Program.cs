using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_17
{
    class Program
    {
        public static double CheckGender(string Gender)
        {
            if (Gender == "Man")
                return 0.73;
            else if (Gender == "Woman")
                return 0.66;
            else
            {
                Console.WriteLine("please enter correctly! ");
                string newGender = Console.ReadLine();
                return CheckGender(newGender);
            }
        }

        public static double Bac(double TotalAlcohol, double Weight, 
                                 double Gender, double LastDrinkPerHours)
        {
            double BAC = (TotalAlcohol * 5.14 / Weight * Gender) - 0.15 * LastDrinkPerHours;
            return BAC;
        }
        static void Main(string[] args)
        {
            Console.Write("total alcohol consumed, in ounces (oz) : ");
            double.TryParse(Console.ReadLine(), out double totalAlcohol);

            Console.Write("body weight in pounds. : ");
            double.TryParse(Console.ReadLine(), out double weightInPounds);

            Console.Write("Your Gender : ");
            string gender = Console.ReadLine();
            double number = CheckGender(gender);

            Console.Write("number of hours since the last drink. : ");
            double.TryParse(Console.ReadLine(), out double lastDrink);
            
            double result = Bac(totalAlcohol, weightInPounds, number, lastDrink);
            Console.WriteLine("your bac is " + result);
            if(result > 0.08)
                Console.WriteLine("It is not legal for you to drive.");
            else
                Console.WriteLine("It is legal to drive :) ");
            Console.ReadKey();
        }
    }
}
