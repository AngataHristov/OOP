
namespace PCCatalog
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    public class Computer
    {
        private string name;

        private decimal price;

        public Computer(string name)
        {
            this.Processor = new Component();
            this.GraphicsCard = new Component();
            this.Motherboard = new Component();
        }

        public Computer(string name, string processorName, decimal processorPrice, string processorDetails,
             string graphicsCardName, decimal graphicsCardPrice, string graphicsCardDetails, string motherboardName, decimal motherboardPrice, string motherboardDetails)
            : this(name)
        {
            this.Name = name;
            this.Processor = new Component(processorName, processorPrice, processorDetails);
            this.GraphicsCard = new Component(graphicsCardName, graphicsCardPrice, graphicsCardDetails);
            this.Motherboard = new Component(motherboardName, motherboardPrice, motherboardDetails);
            this.Price = this.Processor.Price + this.GraphicsCard.Price + this.Motherboard.Price;
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

        public Component Processor { get; private set; }

        public Component GraphicsCard { get; private set; }

        public Component Motherboard { get; private set; }

        /// <summary>
        /// adding or replace components to your PC
        /// </summary>
        /// <param name="componentType"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="details"></param>

        public void AddOrReplaceComponent(ComponentsEnum componentType, string name, decimal price, string details)
        {
            if (componentType == ComponentsEnum.Processor)
            {
                this.Processor = new Component(name, price, details);
            }

            if (componentType == ComponentsEnum.GraphicsCard)
            {
                this.GraphicsCard = new Component(name, price, details);
            }

            if (componentType == ComponentsEnum.Motherboard)
            {
                this.Motherboard = new Component(name, price, details);
            }
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            StringBuilder result = new StringBuilder();
            result.AppendLine("Computer name: " + this.name);
            result.AppendLine("Processor: " + this.Processor.Name);
            result.AppendLine("Processor price: " + this.Processor.Price + " лв.");
            result.AppendLine("Processor details: " + this.Processor.Details);
            result.AppendLine("Graphic card: " + this.GraphicsCard.Name);
            result.AppendLine("Graphic card price: " + this.GraphicsCard.Price + " лв.");
            result.AppendLine("Graphic card details: " + this.GraphicsCard.Details);
            result.AppendLine("Motherboard: " + this.Motherboard.Name);
            result.AppendLine("Motherboard price: " + this.Motherboard.Price + " лв.");
            result.AppendLine("Motherboard details: " + this.Motherboard.Details);
            result.AppendLine("Total price: " + this.Price + " лв.\n");

            return result.ToString();

        }
    }
}
