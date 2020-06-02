using IteratorPattern;
using IteratorPattern.Contract;
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
            IteratorPattern();
        }

        static void MementoPattern()
        {
            Console.WriteLine("\n\nMemento Pattern");
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

        static void IteratorPattern()
        {
            Console.WriteLine("\n\nIterator Pattern");
            IIterableList<string> iterable = new TotallyFineList<string>();
            var counter = 0;
            while (counter++ <= 1)
            {
                iterable.Push("First Value");
                iterable.Push("Second Value");
                iterable.Push("Third Value");
                iterable.Push("Fourth Value");
                var iterator = iterable.CreateIterator();
                while (iterator.HasNext())
                {
                    Console.WriteLine("Iterating over: " + iterator.GetCurrent());
                    iterator.Next();
                }

                // Simulate changing the iterator logic without broke the client
                iterable = new TotallyWeirdList<string>();
            }
        }
    }
}
