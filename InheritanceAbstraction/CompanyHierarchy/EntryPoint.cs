
namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;
    using CompanyHierarchy.People;
    using CompanyHierarchy.Projects;

    public class EntryPoint
    {
        public static void Main()
        {
            List<Sale> sales = new List<Sale>
            {
                new Sale("notebook", 20, DateTime.Now),
                new Sale("pen",2,DateTime.Now)
            };

            SalesEmployee retailer = new SalesEmployee("Kiril", "Petrov", 2314763, Departments.Marketing, 900);

            retailer.AddSale(sales[0]);
            retailer.AddSale(sales[1]);

            var pesho = new Manager("Petur", "Asenov", 3874303, Departments.Accounting, 1200);
            var katya = new Developer("Katya", "Katerina", 5344363, Departments.Production, 2300);
            var ivan = new SalesEmployee("Ivan", "Ivanov", 3429993, Departments.Accounting, 1300);

            var project = new Project("Code", DateTime.Now, ProjectState.Open);

            katya.AddProject(project);

            pesho.AddEmployee(retailer);
            pesho.AddEmployee(katya);
            pesho.AddEmployee(ivan);

            List<Employee> employees = new List<Employee>();

            employees.Add(retailer);
            employees.Add(pesho);
            employees.Add(katya);
            employees.Add(ivan);


            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine(new string('=', 10));

            foreach (var employee in pesho.EmployeesManaged)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
