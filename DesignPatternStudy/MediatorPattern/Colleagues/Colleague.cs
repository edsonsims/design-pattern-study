using MediatorPattern.Contract;
using System.Collections.Generic;

namespace MediatorPattern.Colleagues
{
    public abstract class Colleague
    {
        private List<INotifiable> notifiables = new List<INotifiable>();

        protected void Notify()
        {
            this.notifiables.ForEach(n => n.Notify(this));
        }

        public void AddObserver(INotifiable notifiable)
        {
            this.notifiables.Add(notifiable);
        }

        public void RemoveObserver(INotifiable notifiable)
        {
            this.notifiables.Add(notifiable);
        }
    }
}
