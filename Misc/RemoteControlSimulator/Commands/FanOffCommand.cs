using RemoteControlSimulator.Receivers;

namespace RemoteControlSimulator.Commands
{
    internal class FanOffCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOff();
        }

        public void Undo()
        {
            _fan.TurnOn();
        }
    }
}
