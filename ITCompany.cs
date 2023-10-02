using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    class ITCompany : Company, ICompany
    {
        public ITCompany(string name, int yearOfOpening, int numberOfEmployeesNow, int numberOfEmployeesBefore, int yearlyEarnings)
            : base(name, yearOfOpening, numberOfEmployeesNow, numberOfEmployeesBefore, yearlyEarnings)
        {
            Employees = new List<ITEmployee>();

        }

        public override void BasicInfo()
        {
            Console.WriteLine("IT's Basic Info:");
            base.BasicInfo();
        }

        public void Moto()
        {
            Console.WriteLine("We make far future come true!");
        }

        public void StateOfCompany()
        {
            if (NumberOfEmployeesBefore < NumberOfEmployeesNow)
            {
                Console.WriteLine("State: Growth!");
            }
            else
            {
                Console.WriteLine("State: Fall!");
            }
        }
    }
}
