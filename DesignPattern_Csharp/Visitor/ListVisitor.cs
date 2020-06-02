using System;

namespace Visitor
{
    public class ListVisitor : Visitor
    {
        private string currentDir = "";

        public override void Visit (File file)
        {
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