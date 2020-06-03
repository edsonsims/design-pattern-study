namespace CommandPattern
{
    public class ExampleService
    {
        private string _content;

        public ExampleService(string content)
        {
            _content = content;
        }

        public void TransformContent()
        {
            this._content = "Transformed content"; 
        }

        public void SetContent(string content)
        {
            this._content = content;
        }

        public string GetContent()
        {
            return this._content;
        }
    }
}