using System;

namespace Visitor
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException () : base ()
        {

        }
        public FileTreatmentException (string msg) : base (msg)
        {

        }
    }
}