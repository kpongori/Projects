using System;
using System.Collections.Generic;

namespace Iterator
{
    public class BookShelf : IAggregate
    {
        private List<Book> books;
        // private int last = 0;

        public BookShelf (int maxSize)
        {
            books = new List<Book> (maxSize);
        }
        public Book GetBookAt (int index)
        {
            return books[index];
        }
        public void AppendBook (Book book)
        {
            books.Add (book);
            // last++;
        }
        public int GetLength ()
        {
            return books.Count;
        }
        public IIterator Iterator ()
        {
            return new BookShelfIterator (this);
        }
    }
}