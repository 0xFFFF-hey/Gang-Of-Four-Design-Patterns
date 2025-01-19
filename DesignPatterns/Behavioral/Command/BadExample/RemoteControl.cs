using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.BadExample
{
    internal class RemoteControl
    {
        private Light _light;
        public RemoteControl(Light light)
        {
            _light = light;
        }
        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOn();
            }
            else
            {
                _light.TurnOff();
            }
        }
    }
}
