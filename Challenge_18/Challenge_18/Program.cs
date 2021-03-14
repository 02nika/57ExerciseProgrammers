using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_18
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Press C to convert from Fahrenheit to Celsius.");
            Console.WriteLine("Press F to convert from Celsius to Fahrenheit.");
            Console.WriteLine("Press K to convert from Celsius or Fahrenheit to Kelvin.");
            Console.Write("Your choice: ");

            ConsoleKeyInfo key = Console.ReadKey();
            
            while(true)
            {
                if (key.KeyChar != 'C' && key.KeyChar != 'F' && key.KeyChar != 'K')
                {
                    Console.Write("\ninput correctly please! ");
                    key = Console.ReadKey();
                } 
                else
                {
                    break;
                }
            }
            HotKeyPressed(key);
            Console.WriteLine("Thank you :) ");
            Console.ReadLine();
        }
        private static void HotKeyPressed(ConsoleKeyInfo key) 
        {
            switch (key.Key)
            {
                case ConsoleKey.C:
                    ConvertorFtoC();
                    break;
                case ConsoleKey.F:
                    ConvertorCtoF();
                    break;
                case ConsoleKey.K:
                    KelvinMethod.GetKelvin();
                    break;
                default:
                    break;
            }
            
        }
        private static void ConvertorCtoF()
        {
            //F = (C × 9 / 5) + 32
            Console.WriteLine("\nConvert C to F");
            Console.Write("Please enter the temperature in Celsius: ");
            try
            {
                string celsius = Console.ReadLine();
                double c2 = Convert.ToDouble(celsius);
                double fahrenheit = (c2 * 9 / 5) + 32;
                Console.WriteLine("The temperature in Fahrenheit is " + Math.Round(fahrenheit, 2).ToString());
            }
            catch
            {
                Console.WriteLine("input must be numeric! ");
                ConvertorCtoF();
            }
        }

        private static void ConvertorFtoC()
        {
            //C = (F − 32) × 5 / 9
            Console.WriteLine("\nConvert F to C");
            Console.Write("Please enter the temperature in Fahrenheit: ");
            try
            {
                string fahrenheit = Console.ReadLine();
                double f2 = Convert.ToDouble(fahrenheit);
                double celsius = (f2 - 32) * 5 / 9;
                Console.WriteLine("The temperature in Celsius is " + Math.Round(celsius, 2).ToString());
            }
            catch
            {
                Console.WriteLine("input must be numeric! ");
                ConvertorFtoC();
            }
        }
    }
}
