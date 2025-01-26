using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.BadExample.BackendFramework
{
    internal interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}
