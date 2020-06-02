using System;
using System.Collections.Generic;

namespace Visitor
{
    public abstract class Entry : IElement
    {
        public abstract string GetName ();
        public abstract int GetSize ();
        public abstract void Accept (Visitor visitor);

        public virtual Entry Add (Entry entry)
        {
            throw new FileTreatmentException ();
        }
        public virtual IEnumerable<Entry> Iterator ()
        {
            throw new FileTreatmentException ();
        }
        public override string ToString ()
        {
            return GetName () + " [" + GetSize () + "]";
        }
    }
}