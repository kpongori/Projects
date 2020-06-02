using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main (string[] args)
        {
            // 'H'
            AbstractDisplay d1 = new CharaDisplay ('H');
            // "Hello World"
            AbstractDisplay d2 = new StringDisplay ("Hello, world");
            // "Japanese Greeting"
            AbstractDisplay d3 = new StringDisplay ("こんにちは。");

            d1.Display ();
            d2.Display ();
            d3.Display ();
        }
    }
}