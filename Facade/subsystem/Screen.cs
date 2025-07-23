public class Screen
{
    public readonly string Name;

    public Screen(string name)
    {
        Name = name;
    }

    public void Down()
    {
        Console.WriteLine($"{Name} is now DOWN.");
    }
    public void Up()
    {
        Console.WriteLine($"{Name} is now UP.");
    }
}