using StoreApplication.Models.Classes;

namespace StoreApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StoreApplication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StoreApplication.Models.ApplicationDbContext";
        }

        protected override void Seed(StoreApplication.Models.ApplicationDbContext context)
        {
            
        }
    }
}
