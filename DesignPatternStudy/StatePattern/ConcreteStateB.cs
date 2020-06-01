using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class ConcreteStateB : IState
    {
        public void Handle()
        {
            Console.WriteLine("Handling with B logic");
        }
    }
}
