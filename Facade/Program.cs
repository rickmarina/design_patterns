//Facade pattern: This code demonstrates the Facade pattern, which provides a simplified interface to a complex subsystem.
Console.WriteLine("Facade patter");

// components of the subsystem
Amplifier amplifier = new Amplifier("Top-O-Line Amplifier");
Tuner tuner = new Tuner("Top-O-Line AM/FM Tuner");
DVDPlayer dvdPlayer = new DVDPlayer("Top-O-Line DVD Player");
CDPlayer cdPlayer = new CDPlayer("Top-O-Line CD Player");
Projector projector = new Projector("Top-O-Line Projector");
TheaterLights theaterLights = new TheaterLights("Top-O-Line Theater Lights");
Screen screen = new Screen("Top-O-Line Theater Screen");
PopcornPopper popcornPopper = new PopcornPopper();


HomeTheaterFacade homeTheater = new(cdPlayer, theaterLights, screen, popcornPopper,
                                     amplifier, tuner, dvdPlayer, projector);

homeTheater.WatchMovie("Lord of the Rings - Return of the King");
homeTheater.EndMovie();