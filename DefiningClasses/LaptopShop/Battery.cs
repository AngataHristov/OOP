
namespace LaptopShop
{
    using System;

    public class Battery
    {
        private string batteryType; // Example: Li-Ion, 4-cells

        private int capacity;

        private double lifeTime;

        public Battery()
        {

        }

        public Battery(int initialCapacity, double initialLifeTime, string initialBatteryType = null)
        {
            this.BatteryType = initialBatteryType;
            this.Capacity = initialCapacity;
            this.LifeTime = initialLifeTime;
        }

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The battery type cannot be null or empty text!");
                }

                this.batteryType = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The battery capacity cannot be negative!");
                }

                this.capacity = value;
            }
        }

        public double LifeTime
        {
            get
            {
                return this.lifeTime;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The battery lifetime cannot be negative!");
                }

                this.lifeTime = value;
            }
        }
    }
}
