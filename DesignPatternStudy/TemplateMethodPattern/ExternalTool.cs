using System;

namespace TemplateMethodPattern
{
    public class ExternalTool
    {
        public void ActionBefore()
        {
            Console.WriteLine("External tool action executed before main action");
        }

        public void ActionAfter()
        {
            Console.WriteLine("External tool action executed after main action");
        }
    }
}
