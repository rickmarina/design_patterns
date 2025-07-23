public class CDPlayer
{
    public readonly string Title;

    public CDPlayer(string title)
    {
        Title = title;
    }

    public void Play()
    {
        Console.WriteLine($"{Title} is now playing.");
    }

    public void On()
    {
        Console.WriteLine($"{Title} is now ON.");
    }

    public void Off()
    {
        Console.WriteLine($"{Title} is now OFF.");
    }

    public void Eject()
    {
        Console.WriteLine($"{Title} has been ejected.");
    }
}