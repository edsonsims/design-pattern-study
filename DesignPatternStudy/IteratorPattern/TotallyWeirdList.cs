using IteratorPattern.Contract;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace IteratorPattern
{
    public class TotallyWeirdList<T> : IIterableList<T>
    {
        private T[] _list = new T[10];
        private int _counter;

        public void Push(T item)
        {
            this._list[this._counter++] = item;
        }

        public T Pop()
        {
            return this._list[--this._counter];
        }

        public IIterator<T> CreateIterator()
        {
            Console.WriteLine("Creating a totally weird iterator logic");
            return new TotallyWeirdIteratorList(this);
        }

        public IIterator<T> CreateTotallyWeirdIterator()
        {
            return new TotallyWeirdIteratorList(this);
        }

        public class TotallyWeirdIteratorList : IIterator<T>
        {
            private TotallyWeirdList<T> _container;
            private string _lambs;

            public TotallyWeirdIteratorList(TotallyWeirdList<T> container)
            {
                this._container = container;
                this._lambs = "";
            }

            public T GetCurrent()
            {
                var unnecessaryComplexIndex = (int)(Math.Sqrt(Math.Pow(this.LambsCounter(), 2)) + 2 - (4 * 0.5));
                return this._container._list[unnecessaryComplexIndex];
            }

            public bool HasNext()
            {
                return this.LambsCounter() < this._container._counter;
            }

            public void Next()
            {
                this.AddLamb();
            }

            private int LambsCounter()
            {
                return new Regex("lamb").Matches(this._lambs).Count;
            }

            private void AddLamb()
            {
                this._lambs += " lamb";
            }
        }
    }
}
