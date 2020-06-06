namespace MediatorPattern.Colleagues
{
    public class ConcreteColleagueA : Colleague
    {
        private string _data;

        public string GetContent()
        {
            return this._data;
        }

        public void SetContent(string data)
        {
            System.Console.WriteLine("Setting content to ConcreteColleagueA, value " + data);
            this._data = data;
            this.Notify();
        }
    }
}
