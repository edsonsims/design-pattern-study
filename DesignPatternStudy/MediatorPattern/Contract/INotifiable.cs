using MediatorPattern.Colleagues;

namespace MediatorPattern.Contract
{
    public interface INotifiable
    {
        void Notify(Colleague instance);
    }
}
