// Receivers
using RemoteControlSimulator.Commands;
using RemoteControlSimulator.Receivers;
using RemoteControlSimulator;

Light livingRoomLight = new Light();
Fan ceilingFan = new Fan();

// Commands
ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);
ICommand fanOn = new FanOnCommand(ceilingFan);
ICommand fanOff = new FanOffCommand(ceilingFan);

// Remote Control (Invoker)
RemoteControl remote = new RemoteControl();

// Test Light Commands
remote.SetCommand(lightOn);
remote.PressButton();
remote.PressUndo();

// Test Fan Commands
remote.SetCommand(fanOn);
remote.PressButton();
remote.PressUndo();

// Turn off the light
remote.SetCommand(lightOff);
remote.PressButton();