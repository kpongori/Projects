namespace Adapter
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner (string str) : base (str)
        {

        }
        public void PrintWeak ()
        {
            ShowWithParen ();
        }
        public void PrintStrong ()
        {
            ShowWithAster ();
        }
    }
}