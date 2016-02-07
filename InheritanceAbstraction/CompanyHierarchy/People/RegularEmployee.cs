
namespace CompanyHierarchy.People
{
    using System;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    public abstract class RegularEmployee : Employee, IEmployee, IPerson
    {
        public RegularEmployee(string firstName, string lastName, int id, Departments department, decimal salary)
            : base(firstName, lastName, id, department, salary)
        {

        }
    }
}
