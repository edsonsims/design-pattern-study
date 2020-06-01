namespace StatePattern
{
    public class Context
    {
        private IState _currentState;
        
       public void SetState(IState state)
        {
            System.Console.WriteLine("Changing state");
            this._currentState = state;
        }

        public IState GetCurrentState()
        {
            return this._currentState;
        }
    }
}
