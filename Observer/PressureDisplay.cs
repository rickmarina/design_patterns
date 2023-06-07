public class PressureDisplay : IObserver, IDisplayElement
{

    private float pressure; 
    private readonly ISubject weatherData;

    public PressureDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void display()
    {
        string text = this.pressure switch 
        {
            <= 900f => "Very low atmospheric pressure, characteristic of a tropical cyclone or a highly intense tornado. Indicates very dangerous weather conditions.",
            <= 950f => "Extremely low atmospheric pressure, indicative of a severe storm or a highly intense hurricane.",
            <= 1013f => "Standard atmospheric pressure at sea level. It is considered as the reference pressure in meteorology and is used as a basis for comparing pressure variations.",
            <= 1020f => "High and stable atmospheric pressure. Indicates clear and calm weather conditions.",
            <= 1050f => "Exceptionally high atmospheric pressure, associated with extremely stable weather conditions and clear skies.",
            _ => "Pressure overflow"
        };

        Console.WriteLine($"Atmospheric pressure: {text}");
        
    }

    public void update(float temp, float humidity, float pressure)
    {
        this.pressure = pressure; 
        display();
    }
}