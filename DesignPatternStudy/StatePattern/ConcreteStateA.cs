using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class ConcreteStateA : IState
    {
        public void Handle()
        {
            Console.WriteLine("Handling with A logic.");
        }
    }
}
