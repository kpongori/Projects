using System;

namespace Builder
{
    class Program
    {
        static void Main (string[] args)
        {
            if (args.Length != 1)
            {
                Usage ();
                return;
            }

            if (args[0].Equals ("plain"))
            {
                TextBuilder textBuilder = new TextBuilder ();
                Director director = new Director (textBuilder);
                director.Construct ();
                string result = textBuilder.GetResult ();
                Console.WriteLine (result);
            }
            else if (args[0].Equals ("html"))
            {
                HTMLBuilder htmlBuilder = new HTMLBuilder ();
                Director director = new Director (htmlBuilder);
                director.Construct ();
                string filename = htmlBuilder.GetResult ();
                Console.WriteLine (filename + "が作成されました。");
            }
            else
            {
                Usage ();
                return;
            }
        }

        public static void Usage ()
        {
            Console.WriteLine ("Usage: c# Main plain     プレーンテキストで文書作成");
            Console.WriteLine ("Usage: c# Main html      HTMLで文書作成");
        }
    }
}