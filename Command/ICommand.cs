public interface ICommand
{
    void Execute();
    void Undo();
    // void Redo();
    // bool CanExecute();
    // bool CanUndo();

}