using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.GoodExample
{
    internal abstract class DataDecorator : Data
    {
        protected Data _data;

        public DataDecorator(Data data)
        {
            _data = data;
        }

        public abstract void Save(string data);
    }
}
