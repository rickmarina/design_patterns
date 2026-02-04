using static EventBroker;

public class NotifyService : IObserver
{
    private readonly ILogger<NotifyService> _logger;

    public NotifyService(ISubject eventBroker, ILogger<NotifyService> logger)
    {
        _logger = logger;
        // Suscribirse a eventos específicos
        eventBroker.Suscribe(EventType.UserCreated, this);
    }
    
    public void Update(EventType eventName, object data)
    {
        _logger.LogInformation("NotifyService received event '{EventName}' - Sending notification for: {Data}", eventName, data);
        
        // Aquí podrías enviar emails, push notifications, etc.
        if (data is UserModel user)
        {
            _logger.LogInformation("Would send notification to {UserName}", user.Name);
        }
    }
}