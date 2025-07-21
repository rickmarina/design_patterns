public class TV {
    private readonly string name;

    public TV(string name)
    {
        this.name = name;
    }

    public void On()
    {
        Console.WriteLine($"{name} TV is ON");
    }

    public void Off()
    {
        Console.WriteLine($"{name} TV is OFF");
    }
}