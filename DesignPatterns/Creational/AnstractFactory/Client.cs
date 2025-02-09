using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AnstractFactory
{
    public class Client
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Client(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}
