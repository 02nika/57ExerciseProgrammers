using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_42
{
    class PrintColumns
    {
        public static void PrintResult(List<EmployeeModel> employeeModels)
        {
            int firstNameLength = 0;
            int lastNameLength = 0;
            int salaryLength = 0;
            foreach (EmployeeModel item in employeeModels)
            {
                firstNameLength = ChooseBigger(firstNameLength, item.firstName.Length);
                lastNameLength = ChooseBigger(lastNameLength, item.lastName.Length);
                salaryLength = ChooseBigger(salaryLength, item.salary.ToString().Length);
            }

            Console.Write("Last" + new string(' ', lastNameLength-3) + "First" + new string(' ', firstNameLength - 4) + "Salary\n");
            Console.WriteLine(new string('-', firstNameLength+lastNameLength+salaryLength+7));

            foreach (EmployeeModel item in employeeModels)
            {
                Console.Write(item.firstName + new string(' ', firstNameLength - item.firstName.Length+1));
                Console.Write(item.lastName + new string(' ', lastNameLength - item.lastName.Length+1));
                Console.Write(item.salary.ToString("C") +  "\n");
            }
        }

        private static int ChooseBigger(int firstNameLength, int length)
        {

            if (firstNameLength > length)
                return firstNameLength;
            return length;
            
        }
    }
}
