using ObserverPattern.Model;

namespace ObserverPattern.PushStyle
{
    public class ConcreteSubject : Subject<DataModel>
    {
        public ConcreteSubject(DataModel model)
        {
            this.model = model;
            System.Console.WriteLine("Push Style Subject initialized with value: " + this.model);
        }
    }
}
