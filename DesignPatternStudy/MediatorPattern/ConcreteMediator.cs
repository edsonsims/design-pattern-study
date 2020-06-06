using MediatorPattern.Colleagues;
using System;

namespace MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleagueA _colleagueA;
        private ConcreteColleagueB _colleagueB;

        public ConcreteMediator(ConcreteColleagueA colleagueA, ConcreteColleagueB colleagueB)
        {
            this._colleagueA = colleagueA;
            this._colleagueA.AddObserver(this);
            this._colleagueB = colleagueB;
            this._colleagueB.AddObserver(this);
        }

        public override void Notify(Colleague instance)
        {
            Console.WriteLine("Notification received");
            switch (instance)
            {
                case ConcreteColleagueA concreteA:
                    OnColleagueANotify(concreteA);
                    return;
                case ConcreteColleagueB concreteB:
                    OnColleagueBNotify(concreteB);
                    return;
                default:
                    throw new NotImplementedException();
            }
        }

        public void OnColleagueANotify(ConcreteColleagueA instance)
        {
            Console.WriteLine("Notification receveid from ConcreteColleagueB, value " + instance.GetContent());
            Console.WriteLine("Changing ConcreteColleagueB as side effect");
            this._colleagueB.SetContent(instance.GetContent() + "Buzz");
        }

        public void OnColleagueBNotify(ConcreteColleagueB instance)
        {
            Console.WriteLine("Notification receveid from ConcreteColleagueB, value " + instance.GetContent());
        }
    }
}
