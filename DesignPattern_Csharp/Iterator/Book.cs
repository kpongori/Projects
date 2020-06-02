namespace Iterator
{
    public class Book
    {
        private string name;

        public Book (string name)
        {
            this.name = name;
        }

        public string GetName ()
        {
            return name;
        }
    }
}