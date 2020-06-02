using System;
namespace Proxy
{
    public class Printer : IPrintable
    {
        private string name;

        public Printer ()
        {
            HeavyJob ("Printerのインスタンスを生成中...");
        }
        public Printer (string name)
        {
            this.name = name;
            HeavyJob ("Printerのインスタンス(" + name + ")を生成中...");
        }
        public void SetPrinterName (string name)
        {
            this.name = name;
        }
        public string GetPrinterName ()
        {
            return name;
        }
        public void Print (string str)
        {
            Console.WriteLine ("=== " + name + " ===");
            Console.WriteLine (str);
        }
        private void HeavyJob (string msg)
        {
            Console.WriteLine (msg);
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep (1000);
                Console.Write (".");
            }
            Console.WriteLine ("完了");
        }
    }
}