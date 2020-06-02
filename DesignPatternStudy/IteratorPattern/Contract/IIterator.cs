using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Contract
{
    public interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T GetCurrent();
    }
}
