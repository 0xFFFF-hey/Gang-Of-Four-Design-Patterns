using DesignPatterns.Behavioral.Command.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.GoodExample
{
    internal class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
}
