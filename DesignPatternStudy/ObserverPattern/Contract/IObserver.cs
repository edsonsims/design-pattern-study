namespace ObserverPattern.Contract
{
    public interface IObserver<T>
    {
        void Update(T newValue);
    }
}
