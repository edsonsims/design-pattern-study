using CommandPattern.Contract;

namespace CommandPattern
{
    public class UndoCommand<T> : ICommand
    {
        private History _history;

        public UndoCommand(History history)
        {
            this._history = history;
        }

        public void Execute()
        {
            this._history.Pop().Undo();
        }
    }
}
