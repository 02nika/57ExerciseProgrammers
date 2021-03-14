using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_42
{
    static class WorkingWithCsv
    {
        public static List<EmployeeModel> CsvToList(
            this List<EmployeeModel> list1,
            string address)
        {
            var reader = new StreamReader(address);

            while (!reader.EndOfStream)
            {
                
                var line = reader.ReadLine();
                //Console.WriteLine(line);
                var values = line.Split(',');
                list1.Add(new EmployeeModel()
                {
                    firstName = values[0],
                    lastName = values[1],
                    salary = int.Parse(values[2])
                });
            }
            return list1;
            
        }
    }
}
