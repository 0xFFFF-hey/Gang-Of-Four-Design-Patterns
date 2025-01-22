using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class TaskLogger : ITaskObserver
    {
        private readonly Action<string> _logAction;

        public TaskLogger(Action<string> logAction)
        {
            _logAction = logAction;
        }

        public void Update(string message) => _logAction(message);
    }
}
