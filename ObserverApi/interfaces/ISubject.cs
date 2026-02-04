using static EventBroker;

public interface ISubject
{
    void Suscribe(EventType eventName, IObserver observer);
    void Unsuscribe(EventType eventName, IObserver observer);
    void Notify(EventType eventName, object data);
}