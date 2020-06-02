using System;
using System.IO;

namespace Bridge
{
    public class FileDisplayImpl : DisplayImpl
    {
        private string fileName;
        // Fileから読み込むテキスト行
        private string line;

        public FileDisplayImpl (string fileName = "")
        {
            this.fileName = fileName;
        }

        public override void RawOpen ()
        {
            if (string.IsNullOrEmpty (fileName))
            {
                Console.WriteLine ("Please Enter fileName.");
                return;
            }

            using (StreamReader r = new StreamReader (fileName))
            {
                line = r.ReadToEnd ();
            }
        }

        public override void RawPrint ()
        {
            Console.WriteLine (line);
        }

        public override void RawClose ()
        {

        }
    }
}