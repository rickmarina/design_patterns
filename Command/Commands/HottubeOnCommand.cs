public class HottubeOnCommand : ICommand
{
    private readonly HotTub _hotTub;

    public HottubeOnCommand(HotTub hotTub)
    {
        _hotTub = hotTub;
    }

    public void Execute()
    {
        _hotTub.On();
    }

    public void Undo()
    {
        _hotTub.Off();
    }
    
}