public class Tuner
{
    public readonly string Name;

    public Tuner(string name)
    {
        Name = name;
    }

    public void On()
    {
        Console.WriteLine($"{Name} is now ON.");
    }

    public void SetFrequency(double frequency)
    {
        Console.WriteLine($"{Name} frequency set to {frequency} MHz.");
    }

    public void Off()
    {
        Console.WriteLine($"{Name} is now OFF.");
    }
}