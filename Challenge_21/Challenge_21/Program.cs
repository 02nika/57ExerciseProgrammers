using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_21
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> months = new Dictionary<int, string>()
            {
                {0, "January "},
                {1, "February "},
                {2, "March "},
                {3, "April "},
                {4, "May "},
                {5, "June "},
                {6, "July "},
                {7, "August "},
                {8, "September "},
                {9, "October "},
                {10, "November "},
                {11, "December "}
            };

            Console.Write("Please enter the number of the month: ");
            string number = Console.ReadLine();
            //int.TryParse(number, out int num1);
            months.TryGetValue(Convert.ToInt32(number) - 1, out string value);

            Console.WriteLine("The name of the month is " + value);
            Console.ReadLine();
            
        }
    }
}
