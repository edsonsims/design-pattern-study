using ObserverPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.PullStyle
{
    public class ConcreteSubject : Subject
    {
        private DataModel _model;

        public ConcreteSubject(DataModel model)
        {
            _model = model;
        }

        public DataModel GetValue()
        {
            return this._model;
        }

        public void SetValue(DataModel model)
        {
            this._model = model;
            this.Notify();
        }
    }
}
