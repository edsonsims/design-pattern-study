using IteratorPattern.Contract;

namespace IteratorPattern.Contract
{
    public interface IIterableList<T>
    {
        IIterator<T> CreateIterator();
        T Pop();
        void Push(T item);
    }
}