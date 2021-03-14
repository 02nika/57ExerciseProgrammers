using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_40
{
    public class EmployeeData
    {
        public static List<Employees> employees = new List<Employees>()
            {
                new Employees()
                {
                    firstName = "John",
                    lastName = "Johnson",
                    Position = "Manager",
                    SeperationDate = new DateTime(2016,12,31),
                },
                new Employees()
                {
                    firstName = "Tou",
                    lastName = "Xiong",
                    Position = "Software Engineer",
                    SeperationDate = new DateTime(2016,10,05),
                },
                new Employees()
                {
                    firstName = "Michaela",
                    lastName = "Michaelson",
                    Position = "District Manager",
                    SeperationDate = new DateTime(2015,12,19),
                },
                new Employees()
                {
                    firstName = "Jake",
                    lastName = "Jacobson",
                    Position = "Programmer"
                },
                new Employees()
                {
                    firstName = "Jacquelyn",
                    lastName = "Jackson",
                    Position = "DBA"
                },
                new Employees()
                {
                    firstName = "Sally",
                    lastName = "Weber",
                    Position = "Web Developer",
                    SeperationDate = new DateTime(2015,12,18),
                },
            };
    }
}
