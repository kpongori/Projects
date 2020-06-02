using System;

namespace TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string str;
        private int width;
        public StringDisplay (string str)
        {
            this.str = str;
            // Shift-Jisで取ろうとしたらエラー吐くのでUTF-8にする Shift-Jisがエンコードリストにない？
            width = System.Text.Encoding.UTF8.GetByteCount (str);
            // width = System.Text.Encoding.GetEncoding ("Shift_JIS").GetByteCount (str);
            Console.WriteLine (width);
        }

        protected override void Open ()
        {
            PrintLine ();
        }
        protected override void Print ()
        {
            Console.WriteLine ("|" + str + "|");
        }
        protected override void Close ()
        {
            PrintLine ();
        }

        void PrintLine ()
        {
            Console.Write ("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write ("-");
            }
            Console.WriteLine ("+");
        }
    }
}