using System;

namespace CSharpImplementation
{
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"\nReceiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"\nReceiver: A;so working on ({b}.)");
        }
        
    }
}