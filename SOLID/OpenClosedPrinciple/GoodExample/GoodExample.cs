using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.GoodExample
{
    // Define an interface for shapes
    public interface IShape
    {
        double CalculateArea();
    }

    // Implementing the IShape interface for Circle
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Implementing the IShape interface for Rectangle
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    // AreaCalculator class remains unchanged
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
