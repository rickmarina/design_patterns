public class CeilingFanOffCommand : CeilingFanBaseCommand
{
    public CeilingFanOffCommand(CeilingFan ceilingFan) : base(ceilingFan)
    {
    }

    public override void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Off();
    }

}