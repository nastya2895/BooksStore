using BooksStore.src;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace BooksStore.src
{
    public enum CoverTypes
    {
        Soft,
        Hard
    }

    [Serializable]
    public class Edition
    {
        private String _name;
        private int _pagesCount;
        private int _yearOfPublishing;
        public Book Book { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        public CoverTypes TypeOfCover { get; set; }

        [XmlAttribute("Name")]
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("You did not specify the name of the publication!");
                else _name = value;
            }
        }

        public int PagesCount
        {
            get
            {
                return _pagesCount;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("The number of pages must be greater than 0!");
                else _pagesCount = value;
            }
        }

        public int YearOfPublishing
        {
            get
            {
                return _yearOfPublishing;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("The year of publication cannot be less than 0!");
                else _yearOfPublishing = value;
            }
        }

        public Edition() { }

        public Edition(String name, int pagesCount, int yearOfPublishing, Book book,
                        PublishingHouse publishingHouse, CoverTypes typeOfCover)
        {
            Name = name;
            PagesCount = pagesCount;
            YearOfPublishing = yearOfPublishing;
            Book = book;
            PublishingHouse = publishingHouse;
            TypeOfCover = typeOfCover;
        }

        public void WriteToFile()
        {
            var writer = new XmlSerializer(typeof(Edition));

            FileStream file = File.OpenWrite(@"C:\Users\Admin\source\repos\BooksStore\BooksStore\myFiles\bookStore.xml");

            writer.Serialize(file, this);
            file.Close();
        }
    }
}
