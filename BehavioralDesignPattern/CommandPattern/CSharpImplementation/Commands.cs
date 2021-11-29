using System;

namespace CSharpImplementation
{
    public interface ICommand
    {
        public void Execute();
    }
   
    public class SimpleCommand : ICommand
    {
        private string Payload;
        public SimpleCommand(string payload)
        {
            Payload = payload;   
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing {Payload}");
        }
    }

    public class ComplexCommand : ICommand
    {
        private string a;
        private string b;
        private Receiver receiver;

        public void Execute()
        {
            receiver.DoSomething(a);
            receiver.DoSomethingElse(b);
        }

        public ComplexCommand(string a, string b, Receiver receiver)
        {
            this.receiver = receiver;
            this.a = a;
            this.b = b;
        }
    }
}