using CommandPattern;
using IteratorPattern;
using IteratorPattern.Contract;
using MementoPattern;
using MementoPattern.ExampleModel;
using ObserverPattern;
using ObserverPattern.Model;
using ObserverPattern.Observers;
using StatePattern;
using StrategyPattern;
using StrategyPattern.Strategy.B;
using System;
using TemplateMethodPattern;

namespace DesignPatternStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            MementoPattern();
            StatePattern();
            IteratorPattern();
            StrategyPattern();
            TemplateMethodPattern();
            CommandPattern();
            ObserverPattern();
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
            var context = new StatePattern.Context();

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

        static void StrategyPattern()
        {
            Console.WriteLine("\n\nStrategy Pattern");
            var context = new StrategyPattern.Context(new Type1StrategyA(), new Type1StrategyB());
            context.Apply();
            context.SetStrategyA(new Type2StrategyA());
            context.Apply();

            context.Execute();
            context.SetStrategyB(new Type2StrategyB());
            context.Execute();
        }

        static void TemplateMethodPattern()
        {
            Console.WriteLine("\n\nTemplate Method Pattern");
            var tool = new ExternalTool();
            var concreteA = new ConcreteTemplateA(tool);
            concreteA.Method();

            var concreteB = new ConcreteTemplateB(tool);
            concreteB.Method();
        }

        static void CommandPattern()
        {
            Console.WriteLine("\n\nCommandPattern Pattern");
            var history = new History();
            var exampleService = new ExampleService("Initial value");
            var exampleCommand = new ExampleCommand(history, exampleService);
            var undoCommand = new UndoCommand<string>(history);

            Console.WriteLine(exampleService.GetContent());
            exampleCommand.Execute();
            Console.WriteLine(exampleService.GetContent());
            undoCommand.Execute();
            Console.WriteLine(exampleService.GetContent());
        }

        static void ObserverPattern()
        {
            Console.WriteLine("\n\nObserver Pattern");

            var model = new DataModel(0, "Ball");
            var subject = new ConcreteSubject(model);
            var observerA = new ConcreteObserverA();
            subject.AddObserver(observerA);

            var observerB = new ConcreteObserverB();
            subject.AddObserver(observerB);

            subject.SetValue(new DataModel(1, "Tree"));
            subject.RemoveObserver(observerA);
            subject.SetValue(new DataModel(2, "Car"));
        }
    }
}
