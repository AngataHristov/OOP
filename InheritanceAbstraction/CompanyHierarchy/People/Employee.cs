
namespace CompanyHierarchy.People
{
    using System;
    using Enumerations;
    using CompanyHierarchy.Interfaces;

    public abstract class Employee : Person, IEmployee, IPerson
    {
        private decimal salary;

        public Employee(string firstName, string lastName, int id, Departments department, decimal salary)
            : base(firstName, lastName, id)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public Departments Department { get; private set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative!");
                }

                this.salary = value;
            }
        }
    }
}

