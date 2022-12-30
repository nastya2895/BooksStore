using BooksStore.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.src
{
    public class Product
    {
        public Book Goods { get; set; }
        public int Price { get; set; }

        public Product(Book goods, int price)
        {
            Goods = goods;
            Price = price;
        }
    }
}