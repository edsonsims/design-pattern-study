using ObserverPattern.Model;
using System;

namespace ObserverPattern.Observers.PushStyle
{
    public class ConcreteObserverB: ObserverPattern.PushStyle.Contract.IObserver<DataModel>
    {
        private DataModel _model;

        public void Update(DataModel newValue)
        {
            this._model = newValue;
            Console.WriteLine("Push Style ConcreteObserverB notified, new value: " + _model);
        }
    }
}
