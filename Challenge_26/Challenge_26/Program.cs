using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your balance? ");
            NumberOFMonths.balance = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the APR on the card (as a percent) ? ");
            NumberOFMonths.APR = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the monthly payment you can make? ");
            NumberOFMonths.monthlyPayment = Convert.ToInt32(Console.ReadLine());

            double result = NumberOFMonths.NumberOfTheMonths();
            Console.WriteLine("It will take you " + result + " months to pay off this card.");
            Console.ReadLine();
        }
    }
}
