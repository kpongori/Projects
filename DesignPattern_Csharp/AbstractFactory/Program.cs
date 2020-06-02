using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main (string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine ("Usage: c# Main class.name.of.ConcreteFactory");
                Console.WriteLine ("Example 1: c# Main listfactory.ListFactory");
                Console.WriteLine ("Example 2: c# Main tablefactory.TableFactory");
                return;
            }
            Factory factory = Factory.GetFactory (args[0]);

            Link asahi = factory.CreateLink ("朝日新聞", "http://www.asahi.com/");
            Link yomiuri = factory.CreateLink ("読売新聞", "http://www.yomiuri.co.jp/");
            Link us_yahoo = factory.CreateLink ("Yahoo!", "http://www.yahoo.com/");
            Link jp_yahoo = factory.CreateLink ("Yahoo!Japan", "http://www.yahoo.co.jp");
            Link excite = factory.CreateLink ("Excite", "http://www.excite.com/");
            Link google = factory.CreateLink ("Google", "http://www.google.com");

            Tray trayNews = factory.CreateTray ("新聞");
            trayNews.Add (asahi);
            trayNews.Add (yomiuri);

            Tray trayYahoo = factory.CreateTray ("Yahoo!");
            trayYahoo.Add (us_yahoo);
            trayYahoo.Add (jp_yahoo);

            Tray traySearch = factory.CreateTray ("サーチエンジン");
            traySearch.Add (trayYahoo);
            traySearch.Add (excite);
            traySearch.Add (google);

            Page page = factory.CreatePage ("LinkPage", "結城 浩");
            page.Add (trayNews);
            page.Add (traySearch);
            page.Output ();
        }
    }
}