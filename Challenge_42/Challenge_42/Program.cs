using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Challenge_42
{
    class Program
    {

        static void Main()
        {
            /*
            IEnumerable<string> fileInfo = File.ReadAllLines("data.txt");
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            
            
            employeeModels = employeeModels.GetEmployeeModels(fileInfo);


            PrintColumns.PrintResult(employeeModels.OrderByDescending(x => x.salary));
            */
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            employeeModels = employeeModels.CsvToList("data.csv");

            PrintColumns.PrintResult(employeeModels);

            Console.ReadLine();

        }
    }
}
