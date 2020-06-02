using System;
namespace Composite
{
    public abstract class Entry
    {
        public abstract string GetName ();
        public abstract int GetSize ();

        public virtual Entry Add (Entry entry)
        {
            throw new FileTreatmentException ();
        }
        // public void PrintList ()
        // {
        //     PrintList ("");
        // }
        public abstract void PrintList (string prefix = "");
        public override string ToString ()
        {
            return GetName () + "[" + GetSize () + "]";
        }
    }
}