using System;
using System.Collections.Generic;

namespace Singleton
{
    public class Triple
    {
        // インスタンスの配列を3つまで確保
        private static List<Triple> instances;
        public int id { get; }

        static Triple ()
        {
            instances = new List<Triple> ();
            instances.Add (new Triple ());
            instances.Add (new Triple ());
            instances.Add (new Triple ());
        }
        public Triple ()
        {
            int id = Triple.instances.Count;
            if (id >= 3)
            {
                Console.WriteLine ("limit over.");
                return;
            }
            this.id = id;
        }

        public static Triple GetInstance (int id)
        {
            if (id >= instances.Count)
            {
                return null;
            }
            return instances[id];
        }
    }
}