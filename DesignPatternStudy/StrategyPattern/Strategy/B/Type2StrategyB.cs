using StrategyPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategy.B
{
    public class Type2StrategyB : IStrategyB
    {
        public void Execute()
        {
            Console.WriteLine("Executing Type 2 Strategy B");
        }
    }
}
