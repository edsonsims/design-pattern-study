using StrategyPattern.Contract;
using System;

namespace StrategyPattern
{
    public class Type2StrategyA : IStrategyA
    {
        public void Apply()
        {
            Console.WriteLine("Applying Type 2 Strategy A");
        }
    }
}
