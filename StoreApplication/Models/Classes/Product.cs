using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Models.Classes
{
    public class Product
    {
        public int Id    { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Price { get; set; }

       
    }
}