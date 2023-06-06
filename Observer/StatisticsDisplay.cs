public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float avg;
    private float max;
    private float min;

    private readonly ISubject weatherData;

    public StatisticsDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void display()
    {
        Console.WriteLine($"Avg/Max/Min temperature {this.avg}/{this.max}/{this.min}");
    }

    public void update(float temp, float humidity, float pressure)
    {
        if (this.avg == 0)
            this.avg = temp; 
        else 
            this.avg = (this.avg + temp)/2; 

        display();
    }
}