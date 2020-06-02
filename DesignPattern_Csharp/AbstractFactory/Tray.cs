using System.Collections.Generic;

namespace AbstractFactory
{
    public abstract class Tray : Item
    {
        protected List<Item> tray = new List<Item> ();

        public Tray (string caption) : base (caption)
        {
            tray = new List<Item> ();
        }
        public void Add (Item item)
        {
            tray.Add (item);
        }
    }
}