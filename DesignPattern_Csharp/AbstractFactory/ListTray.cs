using System;
using System.Text;

namespace AbstractFactory
{
    public class ListTray : Tray
    {
        public ListTray (string caption) : base (caption)
        {

        }
        public override string MakeHTML ()
        {
            StringBuilder buffer = new StringBuilder ();
            buffer.Append ("<li>\n");
            buffer.Append (caption + "\n");
            buffer.Append ("<ul>\n");

            foreach (var item in tray)
            {
                buffer.Append (item.MakeHTML ());
            }
            buffer.Append ("</ul>\n");
            buffer.Append ("</li>\n");
            return buffer.ToString ();
        }
    }
}