using System.Collections.Concurrent;

public class EventBroker : ISubject
{
    public enum EventType {
        UserCreated,
        UserDeleted
    }

    private ConcurrentDictionary<EventType, HashSet<IObserver>> _observers = new();
    private readonly ILogger<EventBroker> _logger;

    public EventBroker(ILogger<EventBroker> logger)
    {
        this._logger = logger;
    }
    
    public void Suscribe(EventType eventName, IObserver observer)
    {
        _logger.LogInformation("Suscribing observer {ObserverName} to event '{EventName}'", observer.GetType().Name, eventName);
        
        var observers = _observers.GetOrAdd(eventName, _ => []);
        observers.Add(observer);
    }

    public void Unsuscribe(EventType eventName, IObserver observer)
    {
        if (_observers.TryGetValue(eventName, out var observers))
        {
            // ConcurrentBag no soporta Remove, necesitarías recrear el bag sin el observer
            _logger.LogWarning("Unsuscribe not fully supported with ConcurrentBag");
        }
    }

    public void Notify(EventType eventName, object data)
    {
        // Validar que el dato corresponde al tipo esperado para este evento
        if (!EventTypeMapping.ValidateData(eventName, data))
        {
            var expectedType = EventTypeMapping.GetDataType(eventName);
            var actualType = data?.GetType().Name ?? "null";
            _logger.LogError("Event '{EventName}' expects data of type '{ExpectedType}' but received '{ActualType}'", 
                eventName, expectedType.Name, actualType);
            throw new InvalidOperationException(
                $"Event '{eventName}' expects data of type '{expectedType.Name}' but received '{actualType}'");
        }

        if (_observers.TryGetValue(eventName, out var observers))
        {
            _logger.LogInformation("Notifying {Count} observers about event '{EventName}'", observers.Count, eventName);
            
            foreach (var observer in observers)
            {
                observer.Update(eventName, data);
            }
        }
        else
        {
            _logger.LogWarning("No observers registered for event '{EventName}'", eventName);
        }
    }

}