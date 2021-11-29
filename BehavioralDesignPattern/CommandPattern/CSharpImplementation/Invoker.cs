using System;

namespace CSharpImplementation
{
    public class Invoker
    {
        private ICommand OnStart;
        private ICommand OnFinish;

        public void SetOnStart(ICommand command)
        {
            OnStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            OnFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            OnStart.Execute();

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after i finish?");
            OnFinish.Execute();
        }
    }
}