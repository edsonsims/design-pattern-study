using IteratorPattern;
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
            var iterableList = new IterableList<string>();
            iterableList.Push("First Value");
            iterableList.Push("Second Value");
            iterableList.Push("Third Value");
            iterableList.Push("Fourth Value");

            var iterator = iterableList.CreateIterator();
            Console.WriteLine("Iterating over a common iterator");
            while(iterator.HasNext())
            {
                Console.WriteLine("Iterating over: " + iterator.GetCurrent());
                iterator.Next();
            }

            var weirdIterator = iterableList.CreateTotallyWeirdIterator();
            Console.WriteLine("Iterating over a totally weird iterator");
            while (weirdIterator.HasNext())
            {
                Console.WriteLine("Iterating over: " + weirdIterator.GetCurrent());
                weirdIterator.Next();
            }
        }
    }
}
