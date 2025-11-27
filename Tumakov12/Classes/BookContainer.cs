using System;
using System.Threading.Channels;

namespace Tumakov12.Classes
{
    internal class BookContainer
    {
        public delegate int SortDelegate(Book book1, Book book2);

        public Book[] Books { get; private set; }

        public BookContainer(Book[] books)
        {
            Books = books;
        }

        public Book[] SortBooks(SortDelegate sort)
        {
            if (sort is null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0;  i < Books.Length; i++)
            {
                for (int j = 0; j < Books.Length - (i + 1); j++)
                {
                    if (sort(Books[j], Books[j + 1]) < 0)
                    {
                        Book tempBook = Books[j];
                        Books[j] = Books[j + 1];
                        Books[j + 1] = tempBook;
                    }
                }
            }

            return Books;
        }

        public void PrintBooks()
        {
            string info = string.Empty;
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine(Books[i].ToString());
            }
            Console.WriteLine("\n");
        }
    }
}
