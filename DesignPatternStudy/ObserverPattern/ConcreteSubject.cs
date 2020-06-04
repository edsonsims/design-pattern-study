using ObserverPattern.Model;

namespace ObserverPattern
{
    public class ConcreteSubject : Subject<DataModel>
    {
        public ConcreteSubject(DataModel model)
        {
            this.model = model;
            System.Console.WriteLine("Initialized Subject with value: " + this.model);
        }
    }
}
