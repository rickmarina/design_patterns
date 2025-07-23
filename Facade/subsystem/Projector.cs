public class Projector
{
    public readonly string Name;

    public Projector(string name)
    {
        Name = name;
    }

    public void On()
    {
        Console.WriteLine($"{Name} is now ON.");
    }

    public void Off()
    {
        Console.WriteLine($"{Name} is now OFF.");
    }

    public void WideScreenMode()
    {
        Console.WriteLine($"{Name} is now in wide screen mode.");
    }
}