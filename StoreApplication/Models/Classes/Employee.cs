using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Models.Classes
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string RegistrationNumber { get; set; }

        public Employee()
        {
            Sales = new List<Sale>();
        }
        public  ICollection<Sale> Sales { get; set; }
    }
}