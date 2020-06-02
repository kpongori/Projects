using System;
using System.IO;
using System.Text;

namespace Bridge
{
    // Sample版
    public class FileDisplaySample : DisplayImpl
    {
        private string fileName;
        private StringBuilder buffer;
        private int MAX_READAHEAD_LIMIT = 4096; // 繰り返し表示できる上限

        public FileDisplaySample (string fileName)
        {
            buffer = new StringBuilder ();
            this.fileName = fileName;
        }

        public override void RawOpen ()
        {
            if (string.IsNullOrEmpty (fileName))
            {
                Console.WriteLine ("Please Enter fileName.");
                return;
            }
            using (StreamReader st = new StreamReader (fileName))
            {
                while (sr.Peek () != -1)
                {
                    // 取得時にもう改変を始める
                    // StreamReader.ReadLine()で取得した文字列には改行文字は含まれない
                    buffer.Append ("> ");
                    buffer.Append ((sr.ReadLine ()));
                    buffer.Append ("/n");
                }
                Console.WriteLine ("=-=-=-=-=-= " + fileName + " =-=-=-=-=-=");
            }
        }
        public override void RawPrint ()
        {
            Console.WriteLine (buffer.ToString ());
        }
        public override void RawClose ()
        {
            Console.WriteLine ("=-=-=-=-=-=");
        }
    }
}