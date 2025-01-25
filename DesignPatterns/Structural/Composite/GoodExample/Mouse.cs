using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.GoodExample
{
    internal class Mouse : Item
    {
        private float _price = 18.00f;

        public float GetPrice()
        {
            return _price;
        }
    }
}
