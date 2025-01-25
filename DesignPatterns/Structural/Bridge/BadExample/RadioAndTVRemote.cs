using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.BadExample
{
    internal abstract class RadioAndTVRemote : RemoteControl
    {
        public abstract void ControlTV();

        public abstract void ControlRadio();
    }
}
