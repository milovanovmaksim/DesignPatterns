using System;

namespace PubSubPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pub = new Publisher();
            var sub1 = new Subscriber("sub1", pub);
            pub.DoSomething();
        }
    }
    
    public class CustomEventArgs : EventArgs
    {
        public string Message { get; set; }
        public CustomEventArgs(string message)
        {
            Message = message;
        }
    }

    class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Evennt triggered"));
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> raiseEvent = RaiseCustomEvent;
            if (raiseEvent != null)
            {
                e.Message += $" at {DateTime.Now}";
                RaiseCustomEvent?.Invoke(this, e);
            }
        }
    }

    class Subscriber
    {
        private readonly string _id;
        public Subscriber(string id, Publisher pub)
        {
            _id = id;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"{_id} received this message: {e.Message}");
        }
    }

}
