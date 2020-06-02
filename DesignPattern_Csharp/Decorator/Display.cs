using System;

namespace Decorator
{
    public abstract class Display
    {
        public abstract int GetColumns ();
        public abstract int GetRows ();
        public abstract string GetRwoText (int row);
        public void Show ()
        {
            for (int i = 0; i < GetRows (); i++)
            {
                Console.WriteLine (GetRwoText (i));
            }
        }
    }
}