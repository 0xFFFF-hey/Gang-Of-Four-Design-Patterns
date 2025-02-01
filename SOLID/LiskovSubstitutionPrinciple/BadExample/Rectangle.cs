using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple.BadExample
{
    internal class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
