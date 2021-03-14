using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //bmi = (weight / (height × height))* 703
            //If the BMI is between 18.5 and 25, display that the person is
            //at a normal weight
            Console.WriteLine("if you want to continue this app\nby inputing inches and pounds " +
                                "press A button\nOtherwise press any button button");
            ConsoleKeyInfo button = Console.ReadKey();
            if(button.KeyChar == 'a' || button.KeyChar == 'A')
            {
                Console.Write("\nEnter your height in to the inches: ");
                string text1 = Console.ReadLine();
                double inch = CheckDoubleType(text1);
                Console.Write("\nEnter your weight in to the Pounds: ");
                string text2 = Console.ReadLine();
                double Pound = CheckDoubleType(text2);

                LastWords(inch, Pound);
            }
            else
            {
                Console.Write("\nEnter your height in to the centimeters : ");
                string text1 = Console.ReadLine();
                double centimeters = CheckDoubleType(text1);
                Console.Write("\nEnter your weight in to the kilograms : ");
                string text2 = Console.ReadLine();
                double kilograms = CheckDoubleType(text2);

                LastWords(CentimeterToInch(centimeters), KiloToPounds(kilograms));
            }

            Console.ReadLine();
            
        }

        private static double CheckDoubleType(string text)
        {
            try
            {
                return Convert.ToDouble(text);
            }
            catch
            {
                Console.Write("please input Numeric Type! ");
                string text2 = Console.ReadLine();
                return CheckDoubleType(text2);
            }
            
            
        }

        private static void LastWords(double inches, double Pounds)
        {
            //18.5 and 25 is normal
            //bmi = (weight / (height × height)) * 703
            double bmi = (Pounds / (inches * inches)) * 703;
            if(bmi < 18.5)
                Console.WriteLine("You are underweight. this is not normal... \n  " + Math.Round(bmi, 3).ToString());
            else if(bmi > 25)
                Console.WriteLine("You are overweight. You should see your doctor\n  " + Math.Round(bmi, 3).ToString());
            else
                Console.WriteLine("You are within the ideal weight range.\n  " + Math.Round(bmi, 3).ToString());
        }
        
        private static double KiloToPounds(double number)
        {   
            return Math.Round(number * 2.20462, 3);
        }
        private static double CentimeterToInch(double number)
        {
            return Math.Round(number / 2.54, 3);
        }
    }
}
