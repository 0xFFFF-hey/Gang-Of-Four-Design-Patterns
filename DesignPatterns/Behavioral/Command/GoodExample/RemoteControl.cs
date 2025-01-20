using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Encapsulate a request as an object, thereby letting you parameterize clients with
 * different requests queue, or log requests, and support undoable operations.
 */
namespace DesignPatterns.Behavioral.Command.GoodExample
{
    internal class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        // Allow ability to swap commands at runtime
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

    }
}
