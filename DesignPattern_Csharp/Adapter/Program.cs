using System;

namespace Adapter
{
    class Program
    {
        // static void Main (string[] args)
        // {
        //     IPrint p = new PrintBanner ("Hello");
        //     p.PrintWeak ();
        //     p.PrintStrong ();
        // }

        static void Main (string[] args)
        {
            IFileIO f = new FileProperty ();
            f.SetValue ("year", "2004");
            f.SetValue ("month", "4");
            f.SetValue ("day", "21");
            f.WriteToFile ("newfile.txt");
        }
    }
}