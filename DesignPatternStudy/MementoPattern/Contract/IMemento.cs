namespace MementoPattern.Contract
{
    public interface IMemento<T>
    {
        T GetValue();
    }
}
