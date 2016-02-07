
namespace Shapes.Figures
{
    using System;

    using Shapes.Interfaces;

    public class Rectangle : BasicShape, IShape
    {
        public Rectangle(double width, double heigh)
            : base(width, heigh)
        {

        }

        public override double CalculateArea()
        {
            double area = this.Width * this.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Height + this.Width);
            return perimeter;
        }
    }
}
