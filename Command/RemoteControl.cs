using System.Text;

/// <summary>
/// Invoker class that holds a command and can execute it.
/// This class is part of the Command design pattern, which encapsulates a request as an object
/// </summary>
public class RemoteControl
{
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;
    private ICommand _undoCommand;
    private const int _maxCommands = 7;
    public RemoteControl()
    {
        _onCommands = new ICommand[_maxCommands];
        _offCommands = new ICommand[_maxCommands];

        ICommand noCommand = new NoCommand();
        for (int i = 0; i < _maxCommands; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }

        _undoCommand = noCommand;
    }
    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPressed(int slot)
    {
        _onCommands[slot].Execute();
        _undoCommand = _onCommands[slot];
    }

    public void OffButtonWasPressed(int slot)
    {
        _offCommands[slot]?.Execute();
        _undoCommand = _offCommands[slot];
    }
    
    public void UndoButtonWasPressed()
    {
        _undoCommand?.Undo();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("----- Remote Control -----");
        for (int i = 0; i < _maxCommands; i++)
        {
            sb.Append($"Slot #{i}: ");
            sb.AppendLine("on: " + _onCommands[i].GetType().Name.PadRight(25) + "off: " + _offCommands[i].GetType().Name);
        }
        sb.AppendLine("Undo command: " + _undoCommand.GetType().Name);


        return sb.ToString();
    }
}