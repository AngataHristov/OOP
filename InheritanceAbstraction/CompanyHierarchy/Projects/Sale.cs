
namespace CompanyHierarchy.Projects
{
    using System;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    public class Sale : ISales
    {
        private string productionName;

        private decimal price;

        public Sale(string productionName, decimal price, DateTime date)
        {
            this.ProductionName = productionName;
            this.Price = price;
            this.Date = date;
        }

        public DateTime Date { get; private set; }

        public string ProductionName
        {
            get
            {
                return this.productionName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                this.productionName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price canot be negative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Product: {0}, sold at: {1}, price: {2:c2}",
                this.ProductionName,
                this.Date.Date,
                this.Price);
        }
    }
}
