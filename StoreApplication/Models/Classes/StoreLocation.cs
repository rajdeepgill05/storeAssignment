using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Models.Classes
{
    public class StoreLocation
    {
        public int Id { get; set; }

        public string LocationName { get; set; }

        public StoreLocation()
        {
            Sales = new List<Sale>();
        }
        public  ICollection<Sale> Sales { get; set; }
    }

}