using RemoteControlSimulator.Commands;

namespace RemoteControlSimulator
{
    internal class RemoteControl
    {
        private ICommand _command;
        private Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            _command.Execute();
            _commandHistory.Push(_command);
        }
        public void PressUndo()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand lastCommand = _commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo!");
            }
        }
    }
}
