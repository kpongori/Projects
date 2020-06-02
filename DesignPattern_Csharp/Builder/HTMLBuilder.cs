using System;
using System.IO;
using System.Text;

namespace Builder
{
    public class HTMLBuilder : Builder
    {
        private string filename;
        private StringBuilder buffer = new StringBuilder ();

        public override void MakeTitle (string title)
        {
            // すぐには使わないけどここでファイル名を設定
            filename = title + ".html";
            buffer.Append ("<html><head><title>" + title + "</title></head></body>");
            buffer.Append ("\n");
            buffer.Append ("<h1>" + title + "</h1>");
            buffer.Append ("\n");
        }
        public override void MakeString (string str)
        {
            buffer.Append ("<p>" + str + "</p>");
            buffer.Append ("\n");
        }
        public override void MakeItems (string[] items)
        {
            buffer.Append ("<ul>");
            buffer.Append ("\n");
            for (int i = 0; i < items.Length; i++)
            {
                buffer.Append ("<li>" + items[i] + "</li>");
                buffer.Append ("\n");
            }
            buffer.Append ("</ul>");
            buffer.Append ("\n");
        }
        public override void Close ()
        {
            using (StreamWriter w = new StreamWriter (filename))
            {
                w.WriteLine (buffer.ToString ());
            }
        }

        public string GetResult ()
        {
            return filename;
        }
    }
}