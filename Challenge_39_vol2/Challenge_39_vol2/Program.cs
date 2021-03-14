using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_39_vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeBaseEntities();
           
            var result = context.ITEmployees.OrderBy(e => e.LastName);

            Console.WriteLine("Name\t\t    | Position\t\t| Separation Date");
            Console.WriteLine("--------------------|-------------------|----------------");

            string name;
            foreach (var employee in result)
            {
                name = employee.FirstName + " " + employee.LastName;
                Console.WriteLine(
                    string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                    name, employee.Position, employee.SeperationDate));
            }
            Console.ReadLine();
        }
    }
}
