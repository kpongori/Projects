using System;
using System.Collections.Generic;
using System.IO;

namespace Facade
{
    public class PageMaker
    {
        private PageMaker ()
        {

        }
        public static void MakeWelcomePage (string mailAddr, string fileName)
        {
            Dictionary<string, string> mailDict = Database.GetProperties ("maildata");
            string userName = mailDict[mailAddr];
            HtmlWriter writer = new HtmlWriter (new StreamWriter (fileName));
            writer.Title ("Welcome to " + userName + "'s Page!");
            writer.Paragraph (userName + "のページへようこそ。");
            writer.Paragraph ("メール待っていますね。");
            writer.MailTo (mailAddr, userName);
            writer.Close ();
            Console.WriteLine (fileName + " is created for " + mailAddr + " [" + userName + "]");
        }
    }
}