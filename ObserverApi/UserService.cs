using static EventBroker;

public class UserService : IObserver
{
    private readonly ILogger<UserService> _logger;
    private readonly ISubject _eventBroker;

    public UserService(ISubject eventBroker, ILogger<UserService> logger)
    {
        _logger = logger;
        _eventBroker = eventBroker;
        // Suscribirse solo a los eventos que le interesan
        eventBroker.Suscribe(EventType.UserCreated, this);
        eventBroker.Suscribe(EventType.UserDeleted, this);
    }

    public void CreateUser(UserModel user)
    {
        _logger.LogInformation("User created: {User}", user);
        _eventBroker.Notify(EventType.UserCreated, user);
    }

    public void DeleteUser(UserModel user)
    {
        _logger.LogInformation("User deleted: {User}", user.Name);
        _eventBroker.Notify(EventType.UserDeleted, user.Name);
    }

    public void Update(EventType eventName, object data)
    {
        _logger.LogInformation("UserService received event '{EventName}' with data: {Data}", eventName, data);
        
        // Pattern matching 
        if (data is UserModel user)
        {
            _logger.LogInformation("Processing user: {UserName}", user.Name);
        }
    }
}