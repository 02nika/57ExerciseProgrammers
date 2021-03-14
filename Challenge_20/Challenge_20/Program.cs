using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_20
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, double> citiesTaxes = CitiesAndTaxes();
            Console.Write("What is the order amount ? : ");
            string orderAmount = Console.ReadLine();
            double order= CheckDoubleType(orderAmount);
            Console.Write("What state do you live in? : ");
            string livinState = Console.ReadLine();
            
            Transaction t1 = new Transaction();

            while (true)
            {
                if(citiesTaxes.ContainsKey(livinState.ToUpper()))
                {
                    citiesTaxes.TryGetValue(livinState.ToUpper(), out double tax1);
                    t1.order = order;
                    t1.tax = tax1;
                    break;
                }
                else
                {
                    Console.Write("please enter city the correct way: ");
                    livinState = Console.ReadLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("The tax is GEl: " + t1.tax);
            Console.WriteLine("The total is Gel: " + t1.ToTal());
            
            Console.ReadLine();
        }

        private static double CheckDoubleType(string text)
        {
            try
            {
                double double1 = Convert.ToDouble(text);
                return double1;
            }
            catch
            {
                Console.Write("please enter numeric type! ");
                string newText = Console.ReadLine();
                return CheckDoubleType(newText);
            }
        }

        private static IDictionary<string, double> CitiesAndTaxes()
        {
            IDictionary<string, double> numberNames = new Dictionary<string, double>();
            numberNames.Add("TBILISI", 2);
            numberNames.Add("BATUMI", 2);
            numberNames.Add("KUTAISI", 1.5);
            numberNames.Add("RUSTAVI", 1.5);
            numberNames.Add("GORI", 1);
            numberNames.Add("ZUGDIDI", 1);
            numberNames.Add("POTI", 0.5);
            numberNames.Add("KOBULETI", 1);
            numberNames.Add("KHASHURI", 0.5);
            numberNames.Add("SAMTREDIA", 0.5);
            numberNames.Add("SENAKI", 0.5);
            numberNames.Add("CHIATURA", 0);
            numberNames.Add("MARNEULI", 0);
            return numberNames;
        }
    }
}
