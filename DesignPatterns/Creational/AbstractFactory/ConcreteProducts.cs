using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Concrete Product A1
    public class LightButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a light-themed button");
        }
    }

    // Concrete Product A2
    public class DarkButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a dark-themed button");
        }
    }

    // Concrete Product B1
    public class LightCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a light-themed checkbox");
        }
    }

    // Concrete Product B2
    public class DarkCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a dark-themed checkbox");
        }
    }
}
