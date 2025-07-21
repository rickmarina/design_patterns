public class Stereo 
{
    private readonly string name;
    public Stereo(string name)
    {
        this.name = name;
    }
    public void On()
    {
        Console.WriteLine($"{name} stereo is ON");
    }

    public void Off()
    {
        Console.WriteLine($"{name} stereo is OFF");
    }

    public void SetCD()
    {
        Console.WriteLine($"{name} stereo CD is set");
    }
    public void SetDVD()
    {
        Console.WriteLine($"{name} stereo DVD is set");
    }
    public void SetRadio()
    {
        Console.WriteLine($"{name} stereo Radio is set");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"{name} stereo volume set to {volume}");
    }
}