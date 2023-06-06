public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity; 
    private float pressure; 
    private readonly ISubject weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void display()
    {
        Console.WriteLine($"Current conditions: {this.temperature}C degrees and {this.humidity} humidity.");
    }

    public void update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity; 

        display();
    }
}