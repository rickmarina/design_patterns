using static EventBroker;

public interface ISubject
{
    void Suscribe(EventType eventName, IObserver observer);
    void Unsuscribe(EventType eventName, IObserver observer);
    /// <summary>
    /// Be sure to validate data type expected before notifying observers
    /// </summary>
    /// <param name="eventName">EventType</param>
    /// <param name="data">Type associated with eventType in EventTypeMapping</param>
    /// <exception cref="InvalidOperationException"></exception>
    void Notify(EventType eventName, object data);
}