using MediatorPattern.Colleagues;
using System;

namespace MediatorPattern
{
    public class Mediator
    {
        private ConcreteColleagueA _colleagueA;
        private ConcreteColleagueB _colleagueB;

        public Mediator(ConcreteColleagueA colleagueA, ConcreteColleagueB colleagueB)
        {
            this._colleagueA = colleagueA;
            this._colleagueA.AddObserver(this.OnConcreteColleagueAChanged);
            this._colleagueB = colleagueB;
            this._colleagueB.AddObserver(this.OnConcreteColleagueBChanged);
        }

        public void OnConcreteColleagueAChanged(ConcreteColleagueA instance)
        {
            Console.WriteLine("Notification receveid from ConcreteColleagueB, value " + instance.GetContent());
            Console.WriteLine("Changing ConcreteColleagueB as side effect");
            this._colleagueB.SetContent(instance.GetContent() + "Buzz");
        }

        public void OnConcreteColleagueBChanged(ConcreteColleagueB instance)
        {
            Console.WriteLine("Notification receveid from ConcreteColleagueB, value " + instance.GetContent());
        }
    }
}
