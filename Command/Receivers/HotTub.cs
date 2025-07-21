public class HotTub {
    private readonly string name;

    public HotTub(string name)
    {
        this.name = name;
    }

    public void On()
    {
        Console.WriteLine($"{name} HotTub is ON");
    }

    public void Off()
    {
        Console.WriteLine($"{name} HotTub is OFF");
    }
}