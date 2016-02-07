
namespace Shapes.Figures
{
    using System;

    using Shapes.Interfaces;

    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double heigh)
        {
            this.Width = width;
            this.Height = heigh;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative!");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

    }
}
