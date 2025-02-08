using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.LoggingSystem
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(string environment)
        {
            switch (environment)
            {
                case "Development":
                    return new ConsoleLogger();
                case "Testing":
                    return new FileLogger();
                case "Production":
                    return new CloudLogger();
                default:
                    throw new ArgumentException("Unknown environment");
            }
        }
    }
}
