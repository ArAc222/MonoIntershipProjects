using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    public class SeaCompanyEmployee : Employee
    {
        public string TypeOfJob { get; set; }

        public SeaCompanyEmployee(string name, int age, int salary, string typeOfJob)
            : base(name, age, salary)
        {
            TypeOfJob = typeOfJob;
        }
    }
}
