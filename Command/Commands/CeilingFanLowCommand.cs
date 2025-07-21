public class CeilingFanLowCommand : CeilingFanBaseCommand
{
    public CeilingFanLowCommand(CeilingFan ceilingFan) : base(ceilingFan){}

    public override void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Low();
    }

}