using System;

namespace Iterator
{
    class Program
    {
        static void Main (string[] args)
        {
            BookShelf bookShelf = new BookShelf (4);
            bookShelf.AppendBook (new Book ("Around the World in 80 Days"));
            bookShelf.AppendBook (new Book ("Bible"));
            bookShelf.AppendBook (new Book ("Cinderella"));
            bookShelf.AppendBook (new Book ("Daddy-Long-Legs"));
            bookShelf.AppendBook (new Book ("Manchi"));
            bookShelf.AppendBook (new Book ("Reference Book"));
            IIterator it = bookShelf.Iterator ();
            while (it.HasNext ())
            {
                Book book = (Book) it.Next ();
                Console.WriteLine (book.GetName ());
            }
            // Console.WriteLine("Hello World!");
        }
    }
}