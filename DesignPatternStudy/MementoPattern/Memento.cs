using MementoPattern.Contract;

namespace MementoPattern
{
    public class Memento<T> : IMemento<T>
    {
        private readonly T _value;

        public Memento(T value)
        {
            this._value = value;
        }

        public T GetValue()
        {
            return this._value;
        }

    }
}
