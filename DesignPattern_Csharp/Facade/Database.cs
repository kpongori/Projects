using System.Collections.Generic;
using System.IO;

namespace Facade
{
    public class Database
    {
        private Database ()
        {

        }
        public static Dictionary<string, string> GetProperties (string dbName)
        {
            string fileName = dbName + ".txt";
            using (StreamReader sr = new StreamReader (fileName))
            {
                var dict = new Dictionary<string, string> ();
                while (sr.Peek () != -1)
                {
                    string line = sr.ReadLine ();
                    string[] words = line.Split ('=');
                    dict.Add (words[0], words[1]);
                }
                return dict;
            }
        }
    }
}