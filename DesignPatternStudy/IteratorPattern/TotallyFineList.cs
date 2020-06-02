using IteratorPattern.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace IteratorPattern
{
    public class TotallyFineList<T> : IIterableList<T>
    {
        private List<T> _list = new List<T>();

        public void Push(T item)
        {
            this._list.Add(item);
        }

        public T Pop()
        {
            var item = this._list.Last();
            this._list.Remove(item);
            return item;
        }

        public IIterator<T> CreateIterator()
        {
            Console.WriteLine("Creating a totally fine iterator logic");
            return new TotallyWeirdIteratorList(this);
        }

        public class TotallyWeirdIteratorList : IIterator<T>
        {
            private TotallyFineList<T> _container;
            private string _lambs;

            public TotallyWeirdIteratorList(TotallyFineList<T> container)
            {
                this._container = container;
                this._lambs = "";
            }

            private int LambsCounter()
            {
                return new Regex("lamb").Matches(this._lambs).Count;
            }

            private void AddLamb()
            {
                this._lambs += " lamb";
            }

            public T GetCurrent()
            {
                var unnecessaryComplexIndex = (int)(Math.Sqrt(Math.Pow(this.LambsCounter(), 2)) + 2 - (4 * 0.5));
                return this._container._list[unnecessaryComplexIndex];
            }

            public bool HasNext()
            {
                return this.LambsCounter() < this._container._list.Count;
            }

            public void Next()
            {
                this.AddLamb();
            }
        }
    }
}
