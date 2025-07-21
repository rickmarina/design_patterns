
Console.WriteLine("Command Pattern");


// Test remote control 
/*
RemoteControl remote = new();

CeilingFan ceilingFan = new("Living Room");

CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);


remote.SetCommand(0, ceilingFanMedium, ceilingFanOff);
remote.SetCommand(1, ceilingFanHigh, ceilingFanOff);

remote.OnButtonWasPressed(0);
remote.OffButtonWasPressed(0);
Console.WriteLine(remote);

remote.UndoButtonWasPressed();

remote.OnButtonWasPressed(1);
Console.WriteLine(remote);
remote.UndoButtonWasPressed();
*/

// Macro mode 
RemoteControl remote = new();

Light light = new("Living Room");
TV tv = new("Living Room");
Stereo stereo = new("Living Room");
HotTub hottube = new("Living Room");

LightOnCommand lightOn = new LightOnCommand(light);
LightOffCommand lightOff = new LightOffCommand(light);
TVOnCommand tvOn = new TVOnCommand(tv);
TVOffCommand tvOff = new TVOffCommand(tv);
StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
StereoOffCommand stereoOff = new StereoOffCommand(stereo);
HottubeOnCommand hottubOn = new HottubeOnCommand(hottube);
HottubeOffCommand hottubOff = new HottubeOffCommand(hottube);


ICommand[] partyOn = [lightOn, tvOn , stereoOnWithCD, hottubOn];
ICommand[] partyOff = [lightOff, tvOff, stereoOff, hottubOff];

MacroCommand partyonCommand = new MacroCommand(partyOn);
MacroCommand partyoffCommand = new MacroCommand(partyOff);

remote.SetCommand(0, partyonCommand, partyoffCommand);

System.Console.WriteLine(remote);

System.Console.WriteLine("---- Pushing Macro On ----");
remote.OnButtonWasPressed(0);

System.Console.WriteLine("---- Pushing Macro Off ----");
remote.OffButtonWasPressed(0);

System.Console.WriteLine("---- Undo ----");
remote.UndoButtonWasPressed();