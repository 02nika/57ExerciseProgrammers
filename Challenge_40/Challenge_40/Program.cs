using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Challenge_40
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string> file1 = File.ReadAllLines(@"\nika\\c#\\Challenge_57\\Challenge_40\\Challenge_40\\data.txt");


            List<Employees> list1 = file1.TxtToList();

            foreach (var item in list1)
            {
                Console.WriteLine(item.firstName);
                Console.WriteLine(item.lastName);
            }
            Console.ReadLine();


            /*
            Console.Write("if you want to search by position, enter P. if not never mind: ");
            string positionAsk = Console.ReadLine();
            Console.Write("Enter a search string:  ");
            string input = Console.ReadLine().ToLower();

            List<Employees> result = EmployeeData.employees;


            IEnumerable<Employees> result2 = ListToLower.ToLower(result);


            if (positionAsk != "P")
            {
                Console.WriteLine("Name\t\t    | Position\t\t| Separation Date");
                Console.WriteLine("--------------------|-------------------|----------------");

                string name;
                foreach (var employee in result2.
                    Where(x => x.firstName.Contains(input) ||
                          x.lastName.Contains(input)))
                {
                    name = employee.firstName + " " + employee.lastName;
                    Console.WriteLine(
                        string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                        name, employee.Position, employee.SeperationDate));
                }
            }
            else
            {
                Console.WriteLine("Name\t\t    | Position\t\t| Separation Date");
                Console.WriteLine("--------------------|-------------------|----------------");

                string name;
                foreach (var employee in result2.
                    Where(x => x.Position.Contains(input)))
                {
                    name = employee.firstName + " " + employee.lastName;
                    Console.WriteLine(
                        string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                        name, employee.Position, employee.SeperationDate));
                }
            }
            checkDate(result2);


            Console.ReadLine();
        }

        private static void checkDate(IEnumerable<Employees> result2)
        {
            Console.Write("\n\n\nif you want to find all employees where their separation date is six months ago or more Click Y: ");
            string str = Console.ReadLine();


            if(str == "Y")
            {
                Console.WriteLine("\n\n\nName\t\t    | Position\t\t| Separation Date");
                Console.WriteLine("--------------------|-------------------|----------------");

                string name;
                foreach (var employee in result2.
                    Where(x => DateTime.Now.Date.AddMonths(-6) > x.SeperationDate))
                {
                    name = employee.firstName + " " + employee.lastName;
                    Console.WriteLine(
                        string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                        name, employee.Position, employee.SeperationDate));
                }
            }
            Console.WriteLine("goodbye <3");*/
        }
    }
}
