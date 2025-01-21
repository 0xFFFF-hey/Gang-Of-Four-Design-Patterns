using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    internal class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }

        public void SetTemperature(float temperature)
        {
            this.temperature = temperature;
            NotifyObservers(); // Notify observers whenever temperature changes
        }
    }
}
