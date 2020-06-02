using System;
using System.Text;

namespace Decorator
{
    public class FullBorder : Border
    {
        public FullBorder (Display display) : base (display)
        {

        }
        public override int GetColumns ()
        {
            return 1 + display.GetColumns () + 1;
        }
        public override int GetRows ()
        {
            return 1 + display.GetRows () + 1;
        }
        public override string GetRwoText (int row)
        {
            // 枠の上端
            if (row == 0)
            {
                return "+" + MakeLine ('-', display.GetColumns ()) + "+";
            }
            // 枠の下端
            else if (row == display.GetRows () + 1)
            {
                return "+" + MakeLine ('-', display.GetColumns ()) + "+";
            }
            return "|" + display.GetRwoText (row - 1) + "|";
        }
        private string MakeLine (char ch, int count)
        {
            StringBuilder buffer = new StringBuilder ();
            for (int i = 0; i < count; i++)
            {
                buffer.Append (ch);
            }
            return buffer.ToString ();
        }
    }
}