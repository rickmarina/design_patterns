public class WeatherData : ISubject
{

    private List<IObserver> observers; 
    private float temperature;
    private float humidity; 
    private float pressure; 

    public WeatherData()
    {
        observers = new List<IObserver>();
    }
    public void registerObserver(IObserver o)
    {
        observers.Add(o);
    }
    public void removeObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void notifyObservers()
    {
        foreach (var obs in observers) {
            obs.update(this.temperature,this.humidity,this.pressure);
        }
    }

    public void measeurementsChanged() => notifyObservers();

    public void setMeasurements(float temperature, float humidity, float pressure) { 
        this.temperature = temperature; 
        this.humidity = humidity;
        this.pressure = pressure; 

        measeurementsChanged();
    }

}