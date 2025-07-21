public class GarageDoor
{
    private readonly string name;
    public GarageDoor(string name)
    {
        this.name = name;
    }
    public void Up()
    {
        Console.WriteLine("Garage door is OPEN");
    }

    public void Down()
    {
        Console.WriteLine("Garage door is CLOSED");
    }

    public void Stop()
    {
        Console.WriteLine("Garage door is STOPPED");
    }

    public void LightOn()
    {
        Console.WriteLine("Garage door light is ON");
    }

    public void LightOff()
    {
        Console.WriteLine("Garage door light is OFF");
    }
}