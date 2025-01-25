using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.GoodExample
{
    internal class Box : Item
    {
        private List<Item> items = new List<Item>();

        public void Add(Item item)
        {
            items.Add(item);
        }

        public float GetPrice()
        {
            float total = 0f;
            foreach (var item in items)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
}
