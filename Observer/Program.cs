Console.WriteLine("**** Observer Pattern ****");

WeatherData weatherData = new WeatherData(); 

CurrentConditionsDisplay currentdisplay = new CurrentConditionsDisplay(weatherData); 
StatisticsDisplay statisticsdisplay = new StatisticsDisplay(weatherData); 

weatherData.setMeasurements(22,31,30.4f);
weatherData.setMeasurements(24,31,30.4f);


