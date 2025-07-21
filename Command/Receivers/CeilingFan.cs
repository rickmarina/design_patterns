public class CeilingFan
{
    public const int HIGH = 3;
    public const int MEDIUM = 2;
    public const int LOW = 1;
    public const int OFF = 0;
    private readonly string name;
    private int speed;

    public CeilingFan(string name)
    {
        this.name = name;
        this.speed = OFF;
    }

    public void High()
    {
        speed = HIGH;
        Console.WriteLine($"{name} ceiling fan is on HIGH");
    }
    public void Medium()
    {
        speed = MEDIUM;
        Console.WriteLine($"{name} ceiling fan is on MEDIUM");
    }
    public void Low()
    {
        speed = LOW;
        Console.WriteLine($"{name} ceiling fan is on LOW");
    }

    public void Off()
    {
        Console.WriteLine($"{name} ceiling fan is OFF");
    }
    public int GetSpeed() => speed;
}