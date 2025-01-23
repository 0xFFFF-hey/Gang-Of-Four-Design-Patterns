namespace RemoteControlSimulator.Commands
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
