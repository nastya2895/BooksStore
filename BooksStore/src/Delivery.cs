using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.src
{
    public enum deliveryCompaines
    {
        NovaPoshta,
        UkrPoshta,
    }

    class Delivery
    {
        public deliveryCompaines DeliveryCompany { get; set; }

        public Delivery(deliveryCompaines deliveryCompany)
        {
            DeliveryCompany = deliveryCompany;
        }
    }
}