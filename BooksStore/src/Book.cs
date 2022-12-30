using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BooksStore.src
{
    public enum Genres
    {
        Drama,
        Fantasy,
        FairyTale,
        TravelBooks,
        Autobiography,
        History,
        Thriller,
        Mystery,
        Romance,
        Horror,
        Business,
        Detective
    }

    public class Book
    {
        private String _author;
        public Genres Genre { get; set; }

        [XmlAttribute("Name")]
        public String Name { get; set; }

        public String Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("You did not specify the author!");
                else _author = value;
            }
        }

        public Book(String author, Genres genre, String name)
        {
            Author = author;
            Genre = genre;
            Name = name;
        }

        public Book() { }
    }
}

