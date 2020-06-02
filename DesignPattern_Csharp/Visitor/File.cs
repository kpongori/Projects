namespace Visitor
{
    public class File : Entry
    {
        private string name;
        private int size;

        public File (string name, int size)
        {
            this.name = name;
            this.size = size;
        }
        public override string GetName ()
        {
            return name;
        }
        public override int GetSize ()
        {
            return size;
        }
        public override void Accept (Visitor visitor)
        {
            visitor.Visit (this);
        }
    }
}