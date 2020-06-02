using System;
using System.IO;
using System.Text;

namespace Flyweight
{
    public class BigChar
    {
        private char charName;
        private string fontData;

        public BigChar (char charName)
        {
            this.charName = charName;
            try
            {
                using (StreamReader sr = new StreamReader ("big" + charName + ".txt"))
                {
                    StringBuilder buffer = new StringBuilder ();
                    while (sr.Peek () != -1)
                    {
                        buffer.Append (sr.ReadLine ());
                        buffer.Append ("\n");
                    }
                    this.fontData = buffer.ToString ();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine (e.StackTrace);
            }
        }
        public void Print ()
        {
            Console.Write (fontData);
        }
    }
}