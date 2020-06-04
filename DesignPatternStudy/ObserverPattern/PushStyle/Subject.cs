using ObserverPattern.PushStyle.Contract;
using System.Collections.Generic;

namespace ObserverPattern.PushStyle
{
    public abstract class Subject<T>
    {
        protected T model;
        private List<IObserver<T>> _observers = new List<IObserver<T>>();

        public void AddObserver(IObserver<T> observer)
        {
            System.Console.WriteLine("Push style observer added");
            this._observers.Add(observer);
        }

        public void RemoveObserver(IObserver<T> observer)
        {
            System.Console.WriteLine("Push style observer removed");
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            System.Console.WriteLine("Push style notification sent to observers");
            this._observers.ForEach(o => o.Update(this.model));
        }

        public T GetValue()
        {
            return this.model;
        }

        public void SetValue(T newValue)
        {
            this.model = newValue;
            this.Notify();
        }
    }
}
