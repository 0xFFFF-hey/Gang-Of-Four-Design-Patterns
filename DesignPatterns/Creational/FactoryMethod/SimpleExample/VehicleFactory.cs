using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.SimpleExample
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle(); // Factory Method
    }
}
