using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using CronReporting.Models;

namespace CronReporting.Providers
{

    public class CronosRepository
    {
        private readonly string _contextConnection = ConfigurationManager.AppSettings.Get("ShoppingReporting");

        public int SaveClients(Clients client)
        {
            var ctx = new CronosContext(_contextConnection);
            if (GetByRef(client.client_id))
            {
                client.last_sync_date = client.last_sync_date;
                client.sync_date = DateTime.Now;
                return ctx.SaveChanges();
            }
            ctx.Clients.Add(client);
            return ctx.SaveChanges();
        }

        public bool GetByRef(Guid guid)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                return ctx.Clients.Any(k => k.client_id == guid);
            }

        }
        public int SaveBranch(Branch branch)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Branch.Add(branch);
                return ctx.SaveChanges();
            }

        }
        public int SaveChangingInfo(ChangingInfo changingInfo)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.ChangingInfo.Add(changingInfo);
                return ctx.SaveChanges();
            }

        }

        public int SaveCart(Cart cart)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.Cart.Add(cart);
            return ctx.SaveChanges();
        }

        public int SaveCategory(Category category)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.Category.Add(category);
            return ctx.SaveChanges();
        }

        public int SaveInvoice(Invoice invoice)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.Invoice.Add(invoice);
            return ctx.SaveChanges();

        }public int SaveInvoicedProduct(InvoicedProduct invoicedProduct)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.InvoicedProduct.Add(invoicedProduct);
            return ctx.SaveChanges();

        }

        public int SavePersonalInfo(PersonalInfo personalInfo)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.PersonalInfo.Add(personalInfo);
            return ctx.SaveChanges();
        }

        public int SaveProductAvailableBranch(ProductAvailableBranch productAvailableBranch)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.ProductAvailableBranch.Add(productAvailableBranch);
            return ctx.SaveChanges();

        }

        public int SavProductCategory(ProductCategory productCategory)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.ProductCategory.Add(productCategory);
            return ctx.SaveChanges();
        }
        public int SaveProduct(Product product)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.Product.Add(product);
            return ctx.SaveChanges();
        }

        public int SaveProductCategory(ProductCategory productCategory)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.ProductCategory.Add(productCategory);
            return ctx.SaveChanges();
        }

        public int SaveProductImage(ProductImage productImage)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.ProductImage.Add(productImage);
            return ctx.SaveChanges();

        }

        public int SaveRetailerBranch(RetailerBranch retailerBranch)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.RetailerBranch.Add(retailerBranch);
            return ctx.SaveChanges();
        }
        public int SaveRetailerInfo(RetailerInfo retailerInfo)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.RetailerInfo.Add(retailerInfo);
            return ctx.SaveChanges();

        }

        public int SaveSubscriberInfo(SubscriberInfo subscriberInfo)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.SubscriberInfo.Add(subscriberInfo);
            return ctx.SaveChanges();
        }

        public int SaveUserAccount(UserAccount userAccount)
        {
            var ctx = new CronosContext(_contextConnection);
            ctx.UserAccount.Add(userAccount);
            return ctx.SaveChanges();
        }
    }
}