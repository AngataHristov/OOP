
namespace Shapes
{
    using System;
    using System.Collections.Generic;

    using Shapes.Interfaces;
    using Shapes.Figures;

    public class ShapesMain
    {
        public static void Main()
        {
            List<IShape> figures = new List<IShape>();

            figures.Add(new Circle(3.4));
            figures.Add(new Rectangle(2, 3));
            figures.Add(new Rhombus(4.5, 6));

            foreach (var figure in figures)
            {
                Console.WriteLine("{0:F2}", figure.CalculateArea());
                Console.WriteLine("{0:F2}", figure.CalculatePerimeter());
            }

        }
    }
}
