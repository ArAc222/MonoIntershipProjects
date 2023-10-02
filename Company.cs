using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstIntershipProject
{
    public class Company
    {
        protected string Name;
        protected int YearOfOpening;
        protected int NumberOfEmployeesNow;
        protected int NumberOfEmployeesBefore;
        protected int YearlyEarnings;
        public List<ITEmployee> Employees;
        public List<SeaCompanyEmployee> SeaEmployees;

        public Company(string name, int yearOfOpening, int numberOfEmployeesNow, int numberOfEmployeesBefore, int yearlyEarnings)
        {
            Name = name;
            YearOfOpening = yearOfOpening;
            NumberOfEmployeesNow = numberOfEmployeesNow;
            NumberOfEmployeesBefore = numberOfEmployeesBefore;
            YearlyEarnings = yearlyEarnings;
        }

        public virtual void BasicInfo()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Year of Opening: {YearOfOpening}");
            Console.WriteLine($"Number of Employees Now: {NumberOfEmployeesNow}");
            Console.WriteLine($"Number of Employees Before: {NumberOfEmployeesBefore}");
            Console.WriteLine($"Yearly Earnings: {YearlyEarnings} \n");
        }
    }
}
