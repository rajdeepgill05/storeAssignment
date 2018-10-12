using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Models.Classes
{
    public class Sale
    {
        public int Id { get; set; }

        public DateTimeOffset Date { get; set; }

        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public string StoreLocation { get; set; }
        public virtual StoreLocation Location { get; set; }

        public int EmployeeId     { get; set; }
        public int? AssignedEmployeeID     { get; set; }
        public virtual Employee Employee { get; set; }

        public ICollection<Product> Products { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }
    }
}