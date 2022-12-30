using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.src
{
    public class Order
    {
        public String CustomerName { get; set; }
        public int CustomerPhoneNumber { get; set; }

        public Order(String customerName, int customerPhoneNumber)
        {
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
        }
    }
}
