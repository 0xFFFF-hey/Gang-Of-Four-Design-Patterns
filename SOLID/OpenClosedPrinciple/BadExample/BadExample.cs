using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.BadExample
{
    public class Circle
    {
        public double Radius { get; set; }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Circle)
            {
                var circle = (Circle)shape;
                return Math.PI * Math.Pow(circle.Radius, 2);
            }
            else if (shape is Rectangle)
            {
                var rectangle = (Rectangle)shape;
                return rectangle.Width * rectangle.Height;
            }
            else
            {
                throw new InvalidOperationException("Unknown shape type");
            }
        }
    }
}
