using System.Collections.Generic;

namespace Visitor
{
    public class Directory : Entry
    {
        private string name;
        private List<Entry> dir = new List<Entry> ();

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
            foreach (Entry entry in dir)
            {
                size += entry.GetSize ();
            }
            return size;
        }
        public override Entry Add (Entry entry)
        {
            dir.Add (entry);
            return this;
        }
        public override IEnumerable<Entry> Iterator ()
        {
            return dir;
        }
        public override void Accept (Visitor visitor)
        {
            visitor.Visit (this);
        }
    }
}