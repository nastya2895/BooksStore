using BooksStore.src;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BooksStore.src
{
    public class BookStore
    {
        public String title { get; set; }
        public List<Book> BooksList { get; set; }

        public BookStore()
        {
            BooksList = new List<Book>();
        }

        public void addBook(Book bookToAdd)
        {
            BooksList.Add(bookToAdd);
        }

        public void WriteToFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BookStore));

            String fileName = @"C:\Users\Admin\source\repos\BooksStore\BooksStore\myFiles\bookStore.xml";
            using (Stream writer = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static BookStore ReadFromFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BookStore));

            String fileName = @"C:\Users\Admin\source\repos\BooksStore\BooksStore\myFiles\bookStore.xml";
            using (Stream reader = new FileStream(fileName, FileMode.Open))
            {
                return (BookStore)serializer.Deserialize(reader);
            }
        }

    }
}
