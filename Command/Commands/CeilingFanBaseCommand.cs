public abstract class CeilingFanBaseCommand : ICommand
{
    protected readonly CeilingFan ceilingFan;
    protected int prevSpeed;

    public CeilingFanBaseCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }

    public abstract void Execute();

    public virtual void Undo()
    {
        if (prevSpeed == CeilingFan.HIGH)
        {
            ceilingFan.High();
        }
        else if (prevSpeed == CeilingFan.MEDIUM)
        {
            ceilingFan.Medium();
        }
        else if (prevSpeed == CeilingFan.LOW)
        {
            ceilingFan.Low();
        }
        else
        {
            ceilingFan.Off();
        }
    }
}