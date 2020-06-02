using System;

namespace Bridge
{
    public class CountDisplay : Display
    {
        public CountDisplay (DisplayImpl impl) : base (impl)
        {

        }
        public void MultiDisplay (int times)
        {
            Open ();
            for (int i = 0; i < times; i++)
            {
                Print ();
            }
            Close ();
        }

        public void RandomDisplay (int min = 0, int max = 5)
        {
            Random random = new Random ();
            int times = random.Next (min, max);
            MultiDisplay (times);
        }
    }
}