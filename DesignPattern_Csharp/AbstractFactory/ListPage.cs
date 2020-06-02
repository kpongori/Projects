using System.Text;

namespace AbstractFactory
{
    public class ListPage : Page
    {
        public ListPage (string title, string author) : base (title, author)
        {

        }
        public override string MakeHTML ()
        {
            StringBuilder buffer = new StringBuilder ();
            buffer.Append ("<html><head><title>" + title + "</title></head>\n");
            buffer.Append ("<body>\n");
            buffer.Append ("<h1>" + title + "</h1>\n");
            buffer.Append ("<ul>\n");

            foreach (var item in contents)
            {
                buffer.Append (item.MakeHTML ());
            }

            buffer.Append ("</ul>\n");
            buffer.Append ("<hr><address>" + author + "</address>");
            buffer.Append ("</body></html>\n");
            return buffer.ToString ();
        }
    }
}