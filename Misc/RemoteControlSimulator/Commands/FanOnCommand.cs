using RemoteControlSimulator.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlSimulator.Commands
{
    internal class FanOnCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOn();
        }

        public void Undo()
        {
            _fan.TurnOff();
        }
    }
}
