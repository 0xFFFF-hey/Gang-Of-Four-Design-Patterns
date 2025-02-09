using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AnstractFactory
{
    // Concrete Factory 1
    public class LightThemeFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LightCheckbox();
        }
    }

    // Concrete Factory 2
    public class DarkThemeFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new DarkCheckbox();
        }
    }
}
