using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    class NatureCompany : Company, ICompany
    {
        public NatureCompany(string name, int yearOfOpening, int numberOfEmployeesNow, int numberOfEmployeesBefore, int yearlyEarnings)
            : base(name, yearOfOpening, numberOfEmployeesNow, numberOfEmployeesBefore, yearlyEarnings)
        {
        }

        public override void BasicInfo()
        {
            Console.WriteLine("\nNature Companie's Basic Info:");
            base.BasicInfo();
        }

        public void Moto()
        {
            Console.WriteLine("We make all projects easy!");
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
