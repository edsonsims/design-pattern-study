using ObserverPattern.Model;
using System;

namespace ObserverPattern
{
    public class ConcreteObserverA : Contract.IObserver<DataModel>
    {
        private DataModel _model;

        public void Update(DataModel newValue)
        {
            this._model = newValue;
            Console.WriteLine("Received Update event, new value: " + newValue);
        }
    }
}
