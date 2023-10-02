using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    public class ITEmployee : Employee
    {
        public int YearsOfExperience { get; set; }

        public ITEmployee(string name, int age, int salary, int yearsOfExperience)
            : base(name, age, salary)
        {
            YearsOfExperience = yearsOfExperience;
        }
    }
}
