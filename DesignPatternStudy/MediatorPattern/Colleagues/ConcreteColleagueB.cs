namespace MediatorPattern.Colleagues
{
    public class ConcreteColleagueB : Colleague
    {
        private string _otherData;

        public string GetContent()
        {
            return _otherData;
        }

        public void SetContent(string data)
        {
            System.Console.WriteLine("Setting content to ConcreteColleagueB, value " + data);
            this._otherData = data;
            this.Notify();
        }
    }
}
