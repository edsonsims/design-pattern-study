using ObserverPattern.Model;
using System;

namespace ObserverPattern.PushStyle.Observers
{
    public class ConcreteObserverA : Contract.IObserver<DataModel>
    {
        private DataModel _model;

        public void Update(DataModel newValue)
        {
            this._model = newValue;
            Console.WriteLine("Push Style ConcreteObserverA notified, new value: " + newValue);
        }
    }
}
