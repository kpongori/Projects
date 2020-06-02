namespace TemplateMethod
{
    public abstract class AbstractDisplay
    {
        protected abstract void Open ();
        protected abstract void Print ();
        protected abstract void Close ();

        public void Display ()
        {
            Open ();
            for (int i = 0; i < 5; i++)
            {
                Print ();
            }
            Close ();
        }
    }
}