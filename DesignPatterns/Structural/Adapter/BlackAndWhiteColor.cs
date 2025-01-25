using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    internal class BlackAndWhiteColor : Color
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Applying black and white color to video");
        }
    }
}
