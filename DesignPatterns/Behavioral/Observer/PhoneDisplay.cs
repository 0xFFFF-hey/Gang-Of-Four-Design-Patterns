using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    internal class PhoneDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Phone Display: Temperature updated to {temperature}°C");
        }
    }
}
