using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CronReporting.Models;
using Database = System.Data.Entity.Database;

namespace CronReporting.Providers
{
    public class CronosContext: DbContext
    {
        public CronosContext(string connectionString, bool? dropCreate = false)
            : base(connectionString)
        {
        }

        public CronosContext()
        {
            
        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoicedProduct> InvoicedProduct { get; set; }
        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<ProductAvailableBranch> ProductAvailableBranch { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<RetailerBranch> RetailerBranch { get; set; }
        public DbSet<RetailerInfo> RetailerInfo { get; set; }
        public DbSet<SubscriberInfo> SubscriberInfo { get; set; }
        public DbSet<ChangingInfo> ChangingInfo { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<GreenNoteImports> GreenNoteImports { get; set; }
    }
}