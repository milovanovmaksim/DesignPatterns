using System;

namespace CSharpImplementation
{
    interface ICommand
    {
        public void Execute();
    }
    public class ComplexCommand
    {

    }
    public class SimpleCommand : ICommand
    {
        protected string Payload;
        public SipleCommand(string payload)
        {
            Payload = payload;   
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing {Payload}");
        }
        
    }
}