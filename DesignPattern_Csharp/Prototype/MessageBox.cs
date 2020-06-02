using System;

namespace Prototype
{
    public class MessageBox : Product
    {
        private char decochar;
        public MessageBox (char decochar)
        {
            this.decochar = decochar;
        }

        public override void Use (string s)
        {
            int length = System.Text.Encoding.UTF8.GetByteCount (s);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write (decochar);
            }
            Console.WriteLine ("");
            Console.WriteLine (decochar + " " + s + " " + decochar);
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write (decochar);
            }
            Console.WriteLine ("");
        }
    }
}