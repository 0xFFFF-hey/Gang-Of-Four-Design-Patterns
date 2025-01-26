using DesignPatterns.Creational.FactoryMethod.BadExample.BladeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.BadExample.BackendFramework
{
    internal class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data)
        {
            var viewEngine = new BladeViewEngine(); // PROBLEM: Controller is tightly coupled to this particular view engine -- not flexible
            var html = viewEngine.Render(fileName, data);
            System.Console.WriteLine(html);
        }
    }
}
