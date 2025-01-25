using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.BadExample
{
    internal abstract class RemoteControl
    {
        public abstract void TurnOn();

        public abstract void TurnOff();

        public abstract void VolumeUp();

        public abstract void VolumeDown();
    }
}
