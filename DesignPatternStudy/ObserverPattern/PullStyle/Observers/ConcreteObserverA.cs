using ObserverPattern.PullStyle.Contract;
using System;

namespace ObserverPattern.PullStyle.Observers
{
    public class ConcreteObserverA : IObserver
    {
        private ConcreteSubject _subject;

        public ConcreteObserverA(ConcreteSubject subject)
        {
            this._subject = subject;
        }

        public void Update()
        {
            Console.WriteLine("Pull Style ConcreteObserverA notified, new value: " + this._subject.GetValue());
        }
    }
}
