namespace ObserverPattern.Model
{
    public class DataModel
    {
        public DataModel(int count, string name)
        {
            this.Count = count;
            this.Name = name;
        }

        public int Count { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Count: {1}", this.Name, this.Count); 
        }
    }
}
