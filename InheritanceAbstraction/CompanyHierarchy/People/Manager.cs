
namespace CompanyHierarchy.People
{
    using System;
    using System.Collections.Generic;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    public class Manager : Employee, IManager, IEmployee, IPerson
    {
        private ICollection<IEmployee> employeesManaged;

        public Manager(string firstName, string lastName, int id, Departments department, decimal salary)
            : base(firstName, lastName, id, department, salary)
        {
            this.EmployeesManaged = new List<IEmployee>();
        }

        public ICollection<IEmployee> EmployeesManaged
        {
            get
            {
                return new List<IEmployee>(this.employeesManaged);
            }
            set
            {
                this.employeesManaged = value;
            }
        }

        public void AddEmployee(IEmployee employee)
        {
            this.employeesManaged.Add(employee);
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Manager\n");
            result += string.Format("Employees managed: ");

            List<string> employeeNames = new List<string>();
            foreach (Employee employee in this.EmployeesManaged)
            {
                employeeNames.Add(string.Format("{0} {1}", employee.FirstName, employee.LastName));
            }

            result += string.Join(", ", employeeNames) + "\n";

            return result;
        }
    }
}
