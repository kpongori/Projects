using System;
namespace Prototype
{
    public class UnderlinePen : Product
    {
        private char ulchar;

        public UnderlinePen (char ulchar)
        {
            this.ulchar = ulchar;
        }

        public override void Use (string s)
        {
            int length = System.Text.Encoding.UTF8.GetByteCount (s);
            Console.WriteLine ("\"" + s + "\"");
            Console.Write (" ");
            for (int i = 0; i < length; i++)
            {
                Console.Write (ulchar);
            }
            Console.WriteLine ("");
        }
    }
}