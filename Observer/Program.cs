Console.WriteLine("**** Observer Pattern ****");

WeatherData weatherData = new WeatherData();

// Create displays and register them as observers directly from constructor this way subject is not needed to be public
// and we can avoid any unwanted manipulation from outside
// This way the suscriptors are registered when createad by themselves
CurrentConditionsDisplay currentdisplay = new(weatherData); 
StatisticsDisplay statisticsdisplay = new(weatherData); 
PressureDisplay pressureDisplay = new(weatherData);

weatherData.setMeasurements(22,31,850.4f);
weatherData.setMeasurements(24,31,912.4f);
weatherData.setMeasurements(-6,31,1030.4f);

// Another way to register observers 
List<IObserver> observers = new() { currentdisplay, statisticsdisplay, pressureDisplay };
weatherData.registerObservers(observers);

// Alternative way to register observers (.net9)
weatherData.registerObservers([currentdisplay, statisticsdisplay, pressureDisplay]);

