using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.GoodExample
{
    internal class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(Device device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            System.Console.WriteLine("Setting channel to " + channel);
        }
    }
}
