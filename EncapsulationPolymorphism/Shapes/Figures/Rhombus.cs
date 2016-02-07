
namespace Shapes.Figures
{
    using System;

    using Shapes.Interfaces;


    public class Rhombus : BasicShape, IShape
    {
        public Rhombus(double width, double heigh)
            : base(width, heigh)
        {

        }

        // assume that width and height are the diagonals of rhombus

        private double CalculateSizeA()
        {
            double triangleSizeA = (double)this.Width / 2;
            return triangleSizeA;
        }

        private double CalculateSizeB()
        {
            double triangleSizeB = (double)this.Height / 2;
            return triangleSizeB;
        }

        private double CalculaterhombusSize()
        {
            double rhombusSize = Math.Sqrt(CalculateSizeA() * CalculateSizeA() + CalculateSizeB() * CalculateSizeB());
            return rhombusSize;
        }

        public override double CalculateArea()
        {
            double triangleSizeA = CalculateSizeA();
            double triangleSizeB = CalculateSizeB();

            double area = (double)4 * (triangleSizeA * triangleSizeB) / 2;
            return area;
        }

        public override double CalculatePerimeter()
        {

            double perimeter = 4 * CalculaterhombusSize();
            return perimeter;
        }
    }
}
