using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.GoodExample
{
    internal class Microphone : Item
    {
        private float _price = 29.99f;

        public float GetPrice()
        {
            return _price;
        }
    }
}
