public class CeilingFanHighCommand : CeilingFanBaseCommand
{
    public CeilingFanHighCommand(CeilingFan ceilingFan) : base(ceilingFan){}

    public override void Execute()
    {
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.High();
    }

}