using System.Collections.Generic;

namespace Visitor
{
    public class FileFindVisitor : Visitor
    {
        private string searchFileName = "";
        private List<string> foundFiles = new List<string> ();
        private string currentDir = "";

        public FileFindVisitor (string fileName)
        {
            this.searchFileName = fileName;
        }
        public override void Visit (File file)
        {
            string fileName = file.GetName ();
            if (fileName.Contains (searchFileName))
            {
                foundFiles.Add (fileName);
            }
            Console.WriteLine (currentDir + "/" + file);
        }
        public override void Visit (Directory directory)
        {
            Console.WriteLine (currentDir + "/" + directory);
            string saveDir = currentDir;
            currentDir = currentDir + "/" + directory.GetName ();
            var inumerable = directory.Iterator ();
            foreach (Entry entry in inumerable)
            {
                entry.Accept (this);
            }
            currentDir = saveDir;
        }
    }
}