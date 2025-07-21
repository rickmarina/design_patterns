public class CeilingFanMediumCommand : CeilingFanBaseCommand
{
    public CeilingFanMediumCommand(CeilingFan ceilingFan) : base(ceilingFan){}

    public override void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Medium();
    }

}