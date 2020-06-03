using CommandPattern.Contract;
using System;

namespace CommandPattern
{
    public class ExampleCommand : IUndoableCommand
    {
        private string _prevContent;
        private History _history;
        private ExampleService _service;

        public ExampleCommand(History history, ExampleService service)
        {
            _history = history;
            _service = service;
        }

        public void Execute()
        {
            this._prevContent = this._service.GetContent();
            this._service.TransformContent();
            this._history.Push(this);
        }

        public void Undo()
        {
            this._service.SetContent(this._prevContent);
        }
    }
}
