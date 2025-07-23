public class DVDPlayer
{
    public readonly string Location;

    public DVDPlayer(string title)
    {
        Location = title;
    }

    public void Play(string movie)
    {
        Console.WriteLine($"{Location} is now playing {movie}");
    }

    public void Stop()
    {
        Console.WriteLine($"{Location} has stopped playing.");
    }

    public void On()
    {
        Console.WriteLine($"{Location} is now ON.");
    }

    public void Off()
    {
        Console.WriteLine($"{Location} is now OFF.");
    }
    public void Eject()
    {
        Console.WriteLine($"{Location} has been ejected.");
    }
}