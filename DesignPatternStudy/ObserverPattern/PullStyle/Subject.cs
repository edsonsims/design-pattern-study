using ObserverPattern.PullStyle.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.PullStyle
{
    public abstract class Subject
    {
        private List<IObserver> _observer = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            Console.WriteLine("Pull style observer added");
            this._observer.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Pull style observed removed");
            this._observer.Remove(observer);
        }
        
        public void Notify()
        {
            Console.WriteLine("Pull style notification sent to observers");
            this._observer.ForEach(o => o.Update());
        }
    }
}
