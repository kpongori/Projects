namespace Decorator
{
    public class SideBorder : Border
    {
        private char borderChar;

        public SideBorder (Display display, char ch) : base (display)
        {
            this.borderChar = ch;
        }
        public override int GetColumns ()
        {
            return 1 + display.GetColumns () + 1;
        }
        public override int GetRows ()
        {
            return display.GetRows ();
        }
        public override string GetRwoText (int row)
        {
            return borderChar + display.GetRwoText (row) + borderChar;
        }
    }
}