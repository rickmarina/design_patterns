using static EventBroker;

public class EventTypeMetadata
{
    private static readonly Dictionary<EventType, Type> _eventDataTypes = new()
    {
        { EventType.UserCreated, typeof(UserModel) },
        { EventType.UserDeleted, typeof(string) } // Solo envía el nombre del usuario
    };

    public static Type GetDataType(EventType eventType)
    {
        return _eventDataTypes.TryGetValue(eventType, out var type) 
            ? type 
            : typeof(object);
    }

    public static bool ValidateData(EventType eventType, object data)
    {
        var expectedType = GetDataType(eventType);
        return data == null || expectedType.IsAssignableFrom(data.GetType());
    }
}
