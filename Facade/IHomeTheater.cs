// First step: Think what methods we need from all subsystems to create a home theater experience
// This interface will be implemented by the HomeTheaterFacade class

public interface IHomeTheater
{
    void WatchMovie(string movie);
    void EndMovie();
}