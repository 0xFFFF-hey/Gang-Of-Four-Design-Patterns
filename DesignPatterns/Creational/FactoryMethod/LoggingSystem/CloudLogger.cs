using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.LoggingSystem
{
    public class CloudLogger : ILogger
    {
        public void Log(string message)
        {
            // Simulate sending log to cloud
            Console.WriteLine($"[Cloud] Log sent to cloud: {message}");
        }
    }
}
