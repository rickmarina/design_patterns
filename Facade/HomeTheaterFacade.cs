//Second step: Create a Facade class that will provide a simple interface to the complex subsystem
public class HomeTheaterFacade : IHomeTheater
{

    //Components of the subsystem we are going to use
    private readonly Amplifier _amplifier;
    private readonly Tuner _tuner;
    private readonly DVDPlayer _dvdPlayer;
    private readonly CDPlayer _cdPlayer;
    private readonly Projector _projector;
    private readonly TheaterLights _theaterLights;
    private readonly Screen _screen;
    private readonly PopcornPopper _popcornPopper;

    public HomeTheaterFacade(CDPlayer cdPlayer, TheaterLights theaterLights, Screen screen, PopcornPopper popcornPopper,
                             Amplifier amplifier, Tuner tuner, DVDPlayer dvdPlayer, Projector projector)
    {
        _cdPlayer = cdPlayer;
        _theaterLights = theaterLights;
        _screen = screen;
        _popcornPopper = popcornPopper;
        _amplifier = amplifier;
        _tuner = tuner;
        _dvdPlayer = dvdPlayer;
        _projector = projector;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _popcornPopper.On();
        _popcornPopper.Pop();
        _theaterLights.Dim(10);
        _screen.Down();
        _projector.On();
        _projector.WideScreenMode();
        _amplifier.On();
        _amplifier.SetDVD(_dvdPlayer);
        _amplifier.SetVolume(5);
        _amplifier.SetSurroundSound();
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the movie theater...");
        _popcornPopper.Off();
        _theaterLights.On();
        _screen.Up();
        _projector.Off();
        _amplifier.Off();
        _dvdPlayer.Stop();
        _dvdPlayer.Eject();
        _dvdPlayer.Off();
    }
}