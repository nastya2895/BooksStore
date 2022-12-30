using BooksStore.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.src
{
    public class ShoppingCart
    {
        public List<Product> addedProductsList;

        public ShoppingCart()
        {
            addedProductsList = new List<Product>();
        }

        public void addProduct(Product productToAdd)
        {
            addedProductsList.Add(productToAdd);
        }
    }
}

