
namespace PCCatalog
{
    using System;

    public class Component
    {
        private string name;

        private decimal price;

        private string details;

        public Component()
        {

        }

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty text!");
                }

                this.name = value;
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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price should not be negative value!");
                }

                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            private set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details cannot be empty!");
                }

                this.details = value;
            }
        }
    }
}
