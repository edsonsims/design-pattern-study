namespace CommandPattern.Contract
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}
