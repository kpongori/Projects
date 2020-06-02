using System;

namespace Flyweight
{
    class Program
    {
        static void Main (string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine ("Usage: c# Main digits");
                Console.WriteLine ("Example: c# Main 1212123");
                return;
            }
            BigString bs = new BigString (args[0]);
            bs.Print ();
        }
    }
}