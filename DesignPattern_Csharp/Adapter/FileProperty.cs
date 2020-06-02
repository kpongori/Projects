using System;
using System.Collections.Generic;
using System.IO;

namespace Adapter
{
    public class FileProperty : IFileIO
    {
        private string reader;
        private Dictionary<string, string> buffer;

        public FileProperty ()
        {
            buffer = new Dictionary<string, string> ();
        }

        public void ReadFromFile (string filename)
        {
            using (StreamReader r = new StreamReader (filename))
            {
                string line;
                while ((line = r.ReadLine ()) != null)
                {

                }
            }
        }
        public void WriteToFile (string filename)
        {
            using (StreamWriter w = new StreamWriter (filename))
            {
                foreach (KeyValuePair<string, string> property in buffer)
                {
                    w.WriteLine (property.Key + "=" + property.Value);
                }
            }
        }
        public void SetValue (string key, string value)
        {
            if (buffer.ContainsKey (key))
            {
                Console.WriteLine (key + " is already used.");
                return;
            }
            buffer.Add (key, value);
        }
        public string GetValue (string key)
        {
            return buffer[key];
        }
    }
}