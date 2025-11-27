using System;

namespace Tumakov12.Classes
{
    internal class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }

        public Book(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"\"{Name}\" - {Author} - {Publisher}";
        }
    }
}
