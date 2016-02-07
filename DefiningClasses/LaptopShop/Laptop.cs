
namespace LaptopShop
{
    using System;
    using System.Text;

    public class Laptop
    {
        private string model;

        private string processor;

        private string ram;

        private string graphicCard;

        private string hdd;

        private string screen;

        private decimal price;

        public Laptop(string initialModel, decimal initialPrice, LaptopManufacturers initialManufacturer)
        {
            this.Model = initialModel;
            this.Price = initialPrice;
            this.Manufacturer = initialManufacturer;
           // this.Battery = new Battery();
        }

        public Laptop(string initialModel, LaptopManufacturers initialManufacturer, decimal initialPrice, string initialProcessor = null, string initialRam = null,
            string initialGraphicCard = null, string initialHdd = null, string initialScreen = null)
            : this(initialModel, initialPrice, initialManufacturer)
        {
            this.Processor = initialProcessor;
            this.RAM = initialRam;
            this.GraphicCard = initialGraphicCard;
            this.HDD = initialHdd;
            this.Screen = initialScreen;

        }

        public Laptop(string initialModel, LaptopManufacturers initialManufacturer, decimal initialPrice, int initialCapacity, double initialLifeTime, string initialProcessor = null, string initialRam = null,
            string initialGraphicCard = null, string initialHdd = null, string initialScreen = null, string initialBatteryType = null)
            : this(initialModel, initialManufacturer, initialPrice, initialProcessor, initialRam, initialGraphicCard, initialHdd, initialScreen)
        {
            this.Battery = new Battery(initialCapacity, initialLifeTime, initialBatteryType);
        }

        public LaptopManufacturers Manufacturer { get; private set; }

        public Battery Battery { get; private set; }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The model cannot be null ot empty text!");
                }

                this.model = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The processor cannot be null ot empty text!");
                }

                this.processor = value;
            }
        }


        public string RAM
        {
            get
            {
                return this.ram;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The RAM cannot be null ot empty text!");
                }

                this.ram = value;
            }
        }


        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The graphicCard cannot be null ot empty text!");
                }

                this.graphicCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The HDD cannot be null ot empty text!");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The screen cannot be null ot empty text!");
                }

                this.screen = value;
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
                    throw new ArgumentOutOfRangeException("The price cannot be negative!");
                }

                this.price = value;
            }
        }

        public void AddBattery(int initialCapacity, double initialLifeTime, string initialBatteryType = null)
        {
            this.Battery = new Battery(initialCapacity, initialLifeTime, initialBatteryType);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop description:");
            result.AppendLine("Model: " + this.Model);
            result.AppendLine("Manufacturer: " + this.Manufacturer);

            if (Processor != null)
            {
                result.AppendLine("Processor: " + this.Processor);
            }
            if (RAM != null)
            {
                result.AppendLine("RAM: " + this.RAM);
            }
            if (GraphicCard != null)
            {
                result.AppendLine("Graphics Card: " + this.GraphicCard);
            }
            if (HDD != null)
            {
                result.AppendLine("HDD: " + this.HDD);
            }
            if (screen != null)
            {
                result.AppendLine("Screen: " + this.Screen);
            }
            if (!string.IsNullOrEmpty(this.Battery.BatteryType))
            {
                result.AppendLine("Battery: " + this.Battery.BatteryType);
            }
            if (Battery.Capacity != 0)
            {
                result.AppendLine("Battery: " + this.Battery.Capacity + " mAh");
            }
            if (Battery.LifeTime != 0)
            {
                result.AppendLine("Battery Life: " + this.Battery.LifeTime + "hours");
            }
            result.AppendLine("Price: " + this.Price + " lv.");
            return result.ToString();
        }
    }
}
