
namespace CompanyHierarchy.People
{
    using System;
    using System.Collections.Generic;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    public class SalesEmployee : RegularEmployee, ISalesEmployee, IEmployee, IPerson
    {
        private ICollection<ISales> sales;

        public SalesEmployee(string firstName, string lastName, int id, Departments department, decimal salary)
            : base(firstName, lastName, id, department, salary)
        {
            this.Sales = new List<ISales>();
        }

        public ICollection<ISales> Sales
        {
            get
            {
                return new List<ISales>(this.sales);
            }
            set
            {
                this.sales = value;
            }
        }

        public void AddSale(ISales sale)
        {
            this.sales.Add(sale);
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Sales Employee\n");
            result += string.Format("Sales made: {0}\n", this.Sales.Count);
            return result;
        }
    }
}
