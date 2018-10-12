﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Models.Classes
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name   { get; set; }

        public string Email { get; set; }

        public Customer()
        {
            Sales = new List<Sale>();
        }
        public  ICollection<Sale> Sales { get; set; }
    }

}