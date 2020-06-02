using System;

namespace Bridge
{
    class Program
    {
        static void Main (string[] args)
        {
            Display d1 = new Display (new StringDisplayImpl ("Hello, Japan."));
            Display d2 = new CountDisplay (new StringDisplayImpl ("Hello, World"));
            CountDisplay d3 = new CountDisplay (new StringDisplayImpl ("Hello, Universe."));
            d1.DoDisplay ();
            d2.DoDisplay ();
            d3.DoDisplay ();
            d3.MultiDisplay (5);

            Display d4 = new Display (new FileDisplayImpl ("Sample.txt"));
            d4.DoDisplay ();
        }
    }
}