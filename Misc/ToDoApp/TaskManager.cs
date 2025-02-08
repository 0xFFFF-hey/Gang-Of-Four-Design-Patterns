using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class TaskManager
    {
        private readonly List<string> _tasks = new();
        private readonly List<ITaskObserver> _observers = new();

        public void AddObserver(ITaskObserver observer) => _observers.Add(observer);

        public void AddTask(string task)
        {
            _tasks.Add(task);
            NotifyObservers($"Task Added: {task}");
        }

        public void RemoveTask(string task)
        {
            _tasks.Remove(task);
            NotifyObservers($"Task Removed: {task}");
        }

        private void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public IEnumerable<string> GetTasks() => _tasks;
    }
}
