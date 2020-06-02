using System.IO;

namespace Facade
{
    public class HtmlWriter
    {
        private StreamWriter writer;

        public HtmlWriter (StreamWriter writer)
        {
            this.writer = writer;
        }
        public void Title (string title)
        {
            writer.WriteLine ("<html>");
            writer.WriteLine ("<head>");
            writer.WriteLine ("<title>" + title + "</title>");
            writer.WriteLine ("</head>");
            writer.WriteLine ("<body>");
            writer.WriteLine ("<h1>" + title + "</h1>");
        }
        public void Paragraph (string msg)
        {
            writer.WriteLine ("<p>" + msg + "</p>");
        }
        public void Link (string href, string caption)
        {
            Paragraph ("<a href=\"" + href + "\">" + caption + "</a>");
        }
        public void MailTo (string mailAddr, string userName)
        {
            Link ("MailTo:" + mailAddr, userName);
        }
        public void Close ()
        {
            writer.WriteLine ("</body>");
            writer.WriteLine ("</html>");
            writer.Close ();
        }
    }
}