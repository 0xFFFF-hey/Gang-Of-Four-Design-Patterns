using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Abstract Product A
    public interface IButton
    {
        void Render();
    }

    // Abstract Product B
    public interface ICheckbox
    {
        void Render();
    }
}
