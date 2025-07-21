public class TVOffCommand : ICommand
{
    private readonly TV tv;

    public TVOffCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.Off();
    }

    public void Undo()
    {
        tv.On();
    }
}