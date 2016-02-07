
namespace CompanyHierarchy.People
{
    using System;

    using CompanyHierarchy.Interfaces;

    public class Customer : Person, ICustomer, IPerson
    {
        private decimal netPurchaseAmount;

        public Customer(string firstName, string lastName, int id, decimal netPurchaseAmount)
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount cannot be negative!");
                }

                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Customer\n");
            result += string.Format("Net Spending Amount: {0:c2}\n", this.NetPurchaseAmount);
            return result;
        }
    }
}
