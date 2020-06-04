namespace ObserverPattern.PushStyle.Contract
{
    public interface IObserver<T>
    {
        void Update(T newValue);
    }
}
