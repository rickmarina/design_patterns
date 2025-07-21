public class HottubeOffCommand : ICommand
{
    private readonly HotTub _hotTub;

    public HottubeOffCommand(HotTub hotTub)
    {
        _hotTub = hotTub;
    }

    public void Execute()
    {
        _hotTub.Off();
    }

    public void Undo()
    {
        _hotTub.On();
    }
    
}