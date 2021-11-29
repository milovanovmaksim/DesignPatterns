using System;

namespace CSharpImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say hello!"));

            Receiver receiver = new Receiver();

            invoker.SetOnFinish(new ComplexCommand("Send email", "Save rport", receiver));
            invoker.DoSomethingImportant();

        }
    }
}
