using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_42
{
    public static class ListOfEmployees
    {
        public static List<EmployeeModel> GetEmployeeModels(
            this List<EmployeeModel> list1,
            IEnumerable<string> ienumerable1)
        {
            list1 = new List<EmployeeModel>();
            string[] stringInfo;
            foreach (string item in ienumerable1)
            {
                stringInfo =  item.Split(',');
                list1.Add(
                    new EmployeeModel()
                    {
                        firstName = stringInfo[0],
                        lastName = stringInfo[1],
                        salary = int.Parse(stringInfo[2]),
                    });
            }
            return list1;
        }
    }
}
