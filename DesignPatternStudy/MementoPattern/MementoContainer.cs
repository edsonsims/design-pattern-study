using System;

namespace MementoPattern
{
    public class MementoContainer<T>
    {
        public MementoContainer()
        {

        }

        public MementoContainer(T initialValue)
        {
            _originator.SetContent(initialValue);
        }

        private readonly Originator<T> _originator = new Originator<T>();
        private readonly CareTaker<T> _careTaker = new CareTaker<T>();

        public void SetContent(T newValue)
        {
            _careTaker.Push(_originator.CreateState());
            _originator.SetContent(newValue);
        }

        public T GetContent()
        {
            return this._originator.GetContent();
        }

        public void Undo(int actions = 1)
        {
            if (actions < 0)
                throw new ArgumentOutOfRangeException("actions", "Cannot accept negative values.");

            if (actions > this._careTaker.Count())
                throw new ArgumentOutOfRangeException("actions", "Undo actions is greater than history length.");

            for (int i = 0; i < actions; i++)
                _originator.Restore(this._careTaker.Pop());
        }
    }
}
