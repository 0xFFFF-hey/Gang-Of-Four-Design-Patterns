using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AnstractFactory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
