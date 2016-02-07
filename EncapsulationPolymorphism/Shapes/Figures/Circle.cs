
namespace Shapes.Figures
{
    using System;

    using Shapes.Interfaces;

    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative!");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }
    }
}
