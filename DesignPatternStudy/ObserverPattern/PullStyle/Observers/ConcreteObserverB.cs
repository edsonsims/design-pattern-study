using ObserverPattern.PullStyle.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.PullStyle.Observers
{
    public class ConcreteObserverB : IObserver
    {
        private ConcreteSubject _subject;

        public ConcreteObserverB(ConcreteSubject subject)
        {
            this._subject = subject;
        }

        public void Update()
        {
            Console.WriteLine("Pull Style ConcreteObserverB notified, new value: " + this._subject.GetValue());
        }
    }
}
