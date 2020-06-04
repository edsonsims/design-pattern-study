using ObserverPattern.Contract;
using ObserverPattern.Model;

namespace ObserverPattern.Observers
{
    public class ConcreteObserverB: IObserver<DataModel>
    {
        private DataModel _model;

        public void Update(DataModel newValue)
        {
            this._model = newValue;
            System.Console.WriteLine("ConcreteObserverB received update event, new value: " + _model);
        }
    }
}
