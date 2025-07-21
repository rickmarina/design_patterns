public class Light
{
    private readonly string name;

    public Light(string name)
    {
        this.name = name;
    }

    public void On()
    {
        Console.WriteLine($"{name} light is ON");
    }

    public void Off()
    {
        Console.WriteLine($"{name} light is OFF");
    }
}