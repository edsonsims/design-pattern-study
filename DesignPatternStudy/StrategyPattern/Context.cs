using StrategyPattern.Contract;

namespace StrategyPattern
{
    public class Context
    {
        private IStrategyA _strategyA;
        private IStrategyB _strategyB;

        public Context(IStrategyA strategyA, IStrategyB strategyB)
        {
            this._strategyA = strategyA;
            this._strategyB = strategyB;
        }

        public IStrategyA GetStrategyA()
        {
            return this._strategyA;
        }

        public IStrategyB GetStrategyB()
        {
            return this._strategyB;
        }

        public void SetStrategyA(IStrategyA strategyA)
        {
            System.Console.WriteLine("Changing Strategy A Logic");
            this._strategyA = strategyA;
        }

        public void SetStrategyB(IStrategyB strategyB)
        {
            System.Console.WriteLine("Changing Strategy B Logic");
            this._strategyB = strategyB;
        }
    }
}
