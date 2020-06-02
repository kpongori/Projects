using System;

namespace TemplateMethod
{
    public class CharaDisplay : AbstractDisplay
    {
        private char ch;
        public CharaDisplay (char ch)
        {
            this.ch = ch;
        }
        protected override void Open ()
        {
            Console.Write ("<<");
        }
        protected override void Print ()
        {
            Console.Write (ch);
        }
        protected override void Close ()
        {
            Console.WriteLine (">>");
        }
    }
}