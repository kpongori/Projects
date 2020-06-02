using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> directory = new List<Entry> ();

        public Directory (string name)
        {
            this.name = name;
        }
        public override string GetName ()
        {
            return name;
        }
        public override int GetSize ()
        {
            int size = 0;
            foreach (var entry in directory)
            {
                size += entry.GetSize ();
            }
            return size;
        }
        public override Entry Add (Entry entry)
        {
            directory.Add (entry);
            return this;
        }
        public override void PrintList (string prefix = "")
        {
            Console.WriteLine (prefix + "/" + this);
            foreach (Entry entry in directory)
            {
                entry.PrintList (prefix + "/" + name);
            }
        }
    }
}