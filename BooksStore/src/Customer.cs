using BooksStore.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.src
{
    public class Customer
    {
        public List<Order> CustomersList { get; set; }

        public Customer()
        {
            CustomersList = new List<Order>();
        }

        public void addOrderName(Order orderToAdd)
        {
            CustomersList.Add(orderToAdd);
        }
    }
}