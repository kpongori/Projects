using System;

namespace Observer
{
    public class DigitObserver : IObserver
    {
        public void Update (NumberGenerator generator)
        {
            Console.WriteLine ("DigitObserver:" + generator.GetNumber ());
        }
    }
}