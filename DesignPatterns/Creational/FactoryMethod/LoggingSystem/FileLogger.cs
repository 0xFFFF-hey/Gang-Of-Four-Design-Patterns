using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.LoggingSystem
{
    public class FileLogger : ILogger
    {
        private readonly string filePath = "log.txt";
        public void Log(string message)
        {
            File.AppendAllText(filePath, message + Environment.NewLine);
        }
    }
}
