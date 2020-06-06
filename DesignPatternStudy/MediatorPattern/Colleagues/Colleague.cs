using System;
using System.Collections.Generic;

namespace MediatorPattern.Colleagues
{
    public abstract class Colleague<T> where T: Colleague<T>
    {
        private List<Action<T>> notifiables = new List<Action<T>>();

        protected void Notify()
        {
            this.notifiables.ForEach(n => n.Invoke(this as T));
        }

        public void AddObserver(Action<T> action)
        {
            this.notifiables.Add(action);
        }

        public void RemoveObserver(Action<T> action)
        {
            this.notifiables.Add(action);
        }
    }
}
