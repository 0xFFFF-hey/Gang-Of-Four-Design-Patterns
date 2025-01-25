using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.BadExample
{
    internal abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);
    }
}
