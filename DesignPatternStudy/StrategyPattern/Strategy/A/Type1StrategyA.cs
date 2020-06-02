using StrategyPattern.Contract;
using System;

namespace StrategyPattern
{
    public class Type1StrategyA : IStrategyA
    {
        public void Apply()
        {
            Console.WriteLine("Applying Type 1 Strategy A");
        }
    }
}
