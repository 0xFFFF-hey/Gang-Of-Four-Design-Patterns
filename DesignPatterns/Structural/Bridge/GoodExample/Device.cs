using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.GoodExample
{
    internal interface Device
    {
        public void TurnOn();

        public void TurnOff();

        public void SetChannel(int channel);
    }
}
