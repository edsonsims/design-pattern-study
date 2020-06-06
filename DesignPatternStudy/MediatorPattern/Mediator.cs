using MediatorPattern.Colleagues;
using MediatorPattern.Contract;
using System;

namespace MediatorPattern
{
    public abstract class Mediator : INotifiable
    {
        public abstract void Notify(Colleague instance);
    }
}
