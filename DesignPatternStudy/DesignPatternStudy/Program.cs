using MementoPattern;
using MementoPattern.ExampleModel;
using StatePattern;
using System;

namespace DesignPatternStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            MementoPattern();
            StatePattern();
        }

        static void MementoPattern()
        {
            var container = new MementoContainer<Profile>(new Profile("XPTO", "me@xpto.com", null));
            container.SetContent(new Profile("New XPTO", "new@xpto.com", new DateTime(2000, 1, 1)));
            container.SetContent(new Profile("Updated XPTO", "updated@xpto.com", new DateTime(2001, 11, 11)));
            container.Undo(2);
            Console.WriteLine("Current content " + container.GetContent());
        }       

        static void StatePattern()
        {
            Console.WriteLine("\n\nState Pattern");
            var context = new Context();

            context.SetState(new ConcreteStateA());
            context.GetCurrentState().Handle();

            context.SetState(new ConcreteStateB());
            context.GetCurrentState().Handle();
        }
    }
}
