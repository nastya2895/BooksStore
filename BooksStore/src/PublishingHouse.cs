using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BooksStore.src
{
    public class PublishingHouse
    {
        private String _name;
        private String _country;

        [XmlAttribute("Name")]
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("You did not specify the name of the publisher!");
                else _name = value;
            }
        }

        public String Сountry
        {
            get
            {
                return _country;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("You did not specify the country of publication!");
                else _country = value;
            }
        }

        public PublishingHouse(String name, String country)
        {
            Name = name;
            Сountry = country;
        }

        public PublishingHouse() { }
    }
}

