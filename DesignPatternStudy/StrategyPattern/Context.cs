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

        public void Apply()
        {
            this._strategyA.Apply();
        }

        public void Execute()
        {
            this._strategyB.Execute();
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
