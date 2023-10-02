using System;

namespace MyFirstIntershipProject
{
    class Run
    {
        static void Main(string[] args)
        {
            ITCompany it = new ITCompany("Mono Software", 1990, 1000, 800, 5000000);
            SeaCompany sea = new SeaCompany("Blue Ship", 1985, 800, 1000, 4000000);
            NatureCompany nature = new NatureCompany("World of Nature", 2000, 1200, 700, 8000000);

            it.BasicInfo();
            it.Moto();
            it.StateOfCompany();
            sea.BasicInfo();
            sea.Moto();
            sea.StateOfCompany();
            nature.BasicInfo();
            nature.Moto();
            nature.StateOfCompany();


            it.Employees.Add(new ITEmployee("Sime Simic", 35, 20000, 2));
            it.Employees.Add(new ITEmployee("Pero Peric", 28, 30000, 5));
            sea.SeaEmployees.Add(new SeaCompanyEmployee("Toni Saran", 42, 12000, "Fisherman"));
            sea.SeaEmployees.Add(new SeaCompanyEmployee("Gospodin Ribar", 55, 15000, "Boat Mechanic"));


            Console.WriteLine("\nIT Company Employees:");
            foreach (var employee in it.Employees)
            {
                Console.WriteLine($"Employee Name: {employee.EmployeeName}, Age: {employee.EmployeeAge},Year Salary: {employee.Salary} ,YOExperience: {employee.YearsOfExperience}");
            }

            Console.WriteLine("\nSea Company Employees:");
            foreach (var seaemployee in sea.SeaEmployees)
            {
                Console.WriteLine($"Employee Name: {seaemployee.EmployeeName}, Age: {seaemployee.EmployeeAge},Year Salary: {seaemployee.Salary} ,Type of job: {seaemployee.EmployeeName}");
            }

        }
    }
}
