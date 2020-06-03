using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class ConcreteTemplateA : TemplateMethod
    {
        public ConcreteTemplateA(ExternalTool tool) : base(tool)
        {

        }

        protected override void SubMethod()
        {
            Console.WriteLine("My custom action in ConcreteTemplateA");
        }
    }
}
