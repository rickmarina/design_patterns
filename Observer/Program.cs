Console.WriteLine("**** Observer Pattern ****");

WeatherData weatherData = new WeatherData(); 

CurrentConditionsDisplay currentdisplay = new CurrentConditionsDisplay(weatherData); 
StatisticsDisplay statisticsdisplay = new StatisticsDisplay(weatherData); 
PressureDisplay pressureDisplay = new PressureDisplay(weatherData);

weatherData.setMeasurements(22,31,850.4f);
weatherData.setMeasurements(24,31,912.4f);
weatherData.setMeasurements(-6,31,1030.4f);



