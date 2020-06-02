using System;
namespace Composite
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