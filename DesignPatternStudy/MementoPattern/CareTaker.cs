using MementoPattern.Contract;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    public class CareTaker<T>
    {
        private readonly List<IMemento<T>> states = new List<IMemento<T>>();

        public int Count()
        {
            return states.Count;
        }

        public void Push(IMemento<T> state)
        {
            states.Add(state);
        }

        public IMemento<T> Pop()
        {
            var lastState = states.Last();
            states.Remove(lastState);
            return lastState;
        }
    }
}
