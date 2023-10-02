using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    class SeaCompany : Company, ICompany
    {
        public SeaCompany(string name, int yearOfOpening, int numberOfEmployeesNow, int numberOfEmployeesBefore, int yearlyEarnings)
            : base(name, yearOfOpening, numberOfEmployeesNow, numberOfEmployeesBefore, yearlyEarnings)
        {
            SeaEmployees = new List<SeaCompanyEmployee>();
        }

        public override void BasicInfo()
        {
            Console.WriteLine("\nSea Company's Basic Info:");
            base.BasicInfo();
        }

        public void Moto()
        {
            Console.WriteLine("Trust in the power of the sea!");
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
