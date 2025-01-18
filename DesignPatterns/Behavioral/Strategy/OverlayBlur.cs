using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying blur overlay");
        }
    }
}
