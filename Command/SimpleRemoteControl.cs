/// <summary>
/// Invoker class that holds a command and can execute it.
/// This class is part of the Command design pattern, which encapsulates a request as an object
/// </summary>
public class SimpleRemoteControl
{
    private ICommand? _slot;
    private const int _maxCommands = 7;
    public SimpleRemoteControl()
    {
    }
    public void SetCommand(ICommand command)
    {
        this._slot = command;
    }

    public void ButtonWasPressed()
    {
        if (_slot is not null)
        {
            _slot.Execute();
        }
        else
        {
            Console.WriteLine("No command set.");
        }
    }

}