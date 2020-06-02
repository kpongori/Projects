using System;
namespace Observer
{
    public class GraphObserver : IObserver
    {
        public void Update (NumberGenerator generator)
        {
            Console.WriteLine ("GraphObserver:");
            int count = generator.GetNumber ();
            for (int i = 0; i < count; i++)
            {
                Console.Write ("*");
            }
            Console.WriteLine ("");
        }
    }
}