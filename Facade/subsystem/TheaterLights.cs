public class TheaterLights
{
    public readonly string Name;

    public TheaterLights(string name)
    {
        Name = name;
    }

    public void Dim(int level)
    {
        Console.WriteLine($"{Name} dimmed to {level}%.");
    }

    public void On()
    {
        Console.WriteLine($"{Name} is now ON.");
    }

    public void Off()
    {
        Console.WriteLine($"{Name} is now OFF.");
    }
}