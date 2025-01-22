using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal interface ITaskObserver
    {
        void Update(string message);
    }
}
