using CommandPattern.Contract;
using System.Collections.Generic;

namespace CommandPattern
{
    public class History
    {
        private Stack<IUndoableCommand> stack = new Stack<IUndoableCommand>();

        public void Push(IUndoableCommand item)
        {
            System.Console.WriteLine("Executing Command");
            stack.Push(item);
        }

        public IUndoableCommand Pop()
        {
            System.Console.WriteLine("Undoing command");
            return stack.Pop();
        }
    }
}
