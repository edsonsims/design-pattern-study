using System;

namespace TemplateMethodPattern
{
    public class ConcreteTemplateB : TemplateMethod
    {
        public ConcreteTemplateB(ExternalTool tool) : base(tool)
        {

        }

        protected override void SubMethod()
        {
            Console.WriteLine("My custom action in ConcreteTemplateB");
        }
    }
}
