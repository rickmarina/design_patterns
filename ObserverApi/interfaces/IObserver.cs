using static EventBroker;

public interface IObserver
{
    void Update(EventType eventName, object data);
}