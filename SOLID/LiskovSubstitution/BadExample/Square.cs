using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple.BadExample
{
    internal class Square : Rectangle
    {
        public override double Width
        {
            set { base.Width = base.Height = value; } // Forces width and height to be the same
        }

        public override double Height
        {
            set { base.Width = base.Height = value; } // Forces width and height to be the same
        }
    }
}
