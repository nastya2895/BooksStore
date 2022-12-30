using System;
using System.Security.Cryptography.X509Certificates;
using static BooksStore.src.FunctionsForChoice;

namespace BooksStore.src
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishingHouse ph1 = new PublishingHouse("Publishing house of US", "USA");
            Book myBook1 = new Book("Joanne Rowling", Genres.Fantasy, "Harry Potter");
            Edition myEdition1 = new Edition("The second", 525, 2012, myBook1, ph1, CoverTypes.Hard);

            PublishingHouse ph2 = new PublishingHouse("Publishing house of London", "USA");
            Book myBook2 = new Book("Mark Twen", Genres.TravelBooks, "Tom Sawyer");
            Edition myEdition2 = new Edition("The third", 355, 1990, myBook2, ph2, CoverTypes.Hard);

            PublishingHouse ph3 = new PublishingHouse("KM-BUKS", "USA");
            Book myBook3 = new Book("Gillian Flynn", Genres.Thriller, "Lost");
            Edition myEdition3 = new Edition("The first", 480, 2017, myBook3, ph3, CoverTypes.Hard);

            PublishingHouse ph4 = new PublishingHouse("Folio", "Sweden");
            Book myBook4 = new Book("Stieg Larsson", Genres.Detective, "Men who hate women");
            Edition myEdition4 = new Edition("The first", 702, 2010, myBook4, ph4, CoverTypes.Hard);

            PublishingHouse ph5 = new PublishingHouse("Exmo", "USA");
            Book myBook5 = new Book("John Marrs", Genres.Detective, "The One");
            Edition myEdition5 = new Edition("The second", 416, 2020, myBook5, ph5, CoverTypes.Soft);

            PublishingHouse ph6 = new PublishingHouse("Exmo", "USA");
            Book myBook6 = new Book("Jack London", Genres.TravelBooks, "Road");
            Edition myEdition6 = new Edition("The second", 416, 1907, myBook6, ph6, CoverTypes.Soft);

            PublishingHouse ph7 = new PublishingHouse("Oxford University Press", "Great Britain");
            Book myBook7 = new Book("Brothers Grimm", Genres.FairyTale, "Twelve Dancing Princesses");
            Edition myEdition7 = new Edition("The third", 16, 2012, myBook7, ph7, CoverTypes.Soft);

            BookStore myBookStore = new BookStore();
            myBookStore.title = "Central Book Store";
            myBookStore.addBook(myBook1);
            myBookStore.addBook(myBook2);
            myBookStore.addBook(myBook3);
            myBookStore.addBook(myBook4);
            myBookStore.addBook(myBook5);
            myBookStore.addBook(myBook6);
            myBookStore.addBook(myBook7);

            myBookStore.WriteToFile();
            BookStore readedBookStore = BookStore.ReadFromFile();

            Order person1 = new Order("Nastya", 0994563892);
            Order person2 = new Order("Dasha", 0674920489);
            Order person3 = new Order("Stas", 0731852657);

            Customer myOrderName = new Customer();
            myOrderName.addOrderName(person1);
            myOrderName.addOrderName(person2);
            myOrderName.addOrderName(person3);

            Console.WriteLine("\nHi everybody! Welcome to the bookstore 'BooksForYou'!\n");
            ChoicePerson(myOrderName);

            Product product1 = new Product(myBook1, 370);
            Product product2 = new Product(myBook2, 290);
            Product product3 = new Product(myBook3, 300);
            Product product4 = new Product(myBook4, 470);
            Product product5 = new Product(myBook5, 100);
            Product product6 = new Product(myBook6, 450);
            Product product7 = new Product(myBook7, 220);

            ShoppingCart myOrderedProduct = new ShoppingCart();
            myOrderedProduct.addProduct(product1);
            myOrderedProduct.addProduct(product2);
            myOrderedProduct.addProduct(product3);
            myOrderedProduct.addProduct(product4);
            myOrderedProduct.addProduct(product5);
            myOrderedProduct.addProduct(product6);
            myOrderedProduct.addProduct(product7);
            PriceForOrder(myOrderedProduct);

            ChoiceOfDelivery();
        }
    }
}