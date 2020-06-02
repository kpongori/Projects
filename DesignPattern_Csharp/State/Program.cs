using System;

namespace State
{
    class Program
    {
        static void Main (string[] args)
        {
            SafeFrame frame = new SafeFrame ("State Sample");
            while (true)
            {
                for (int hour = 0; hour < 24; hour++)
                {
                    frame.SetClock (hour);
                }
            }
        }
    }
}