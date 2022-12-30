using BooksStore.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore.src
{
    class DeliveryByCurier : Delivery
    {
        public string Adress { get; set; }

        public DeliveryByCurier(deliveryCompaines deliveryCompany, string adress)
            : base(deliveryCompany)
        {
            Adress = adress;
        }
    }
}