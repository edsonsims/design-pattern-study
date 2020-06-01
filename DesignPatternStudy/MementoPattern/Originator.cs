using MementoPattern.Contract;

namespace MementoPattern
{
    public class Originator<T>
    {
        private T _current;

        public T GetContent()
        {
            return this._current;
        }

        public void SetContent(T content)
        {
            System.Console.WriteLine("Setting content to " + content);
            this._current = content;
        }

        public IMemento<T> CreateState()
        {
            var memento = new Memento<T>(_current);
            return memento;
        }

        public void Restore(IMemento<T> state)
        {
            System.Console.WriteLine("Restoring content to " + state.GetValue());
            this._current = state.GetValue();
        }
    }
}
