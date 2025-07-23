public class Amplifier
{
    public readonly string Name;
    private int level;

    public Amplifier(string name)
    {
        Name = name;
    }

    public void On()
    {
        Console.WriteLine($"{Name} is now ON.");
    }

    public void SetDVD(DVDPlayer dvd)
    {
        System.Console.WriteLine($"{Name} setting DVD to {dvd.Location}.");
    }

    public void SetVolume(int level)
    {
        this.level = level;
        Console.WriteLine($"{Name} volume set to {level}.");
    }
    public void SetSurroundSound()
    {
        Console.WriteLine($"{Name} surround sound is ON.");
    }
    public void Off()
    {
        Console.WriteLine($"{Name} is now OFF.");
    }
}