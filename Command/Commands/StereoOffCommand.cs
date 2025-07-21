public class StereoOffCommand : ICommand
{
    private readonly Stereo _stereo;

    public StereoOffCommand(Stereo stereo)
    {
        _stereo = stereo;
    }

    public void Execute()
    {
        _stereo.SetVolume(0);
        _stereo.Off();
    }

    public void Undo()
    {
        _stereo.On();
        _stereo.SetVolume(10);
    }
}