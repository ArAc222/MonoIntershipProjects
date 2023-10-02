using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }

        public int Salary { get; set; }

        protected Employee(string name, int age, int salary)
        {
            EmployeeName = name;
            EmployeeAge = age;
            Salary = salary;
        }
    }
}
