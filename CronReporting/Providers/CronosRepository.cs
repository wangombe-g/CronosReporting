using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using CronReporting.Models;

namespace CronReporting.Providers
{

    public class CronosRepository
    {
        private readonly string _contextConnection = ConfigurationManager.AppSettings.Get("ShoppingReporting");

        public void SaveClients(Clients client)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                if (GetByRef(client.client_id))
                {
                    client.last_sync_date = client.last_sync_date;
                    client.sync_date = DateTime.Now;
                    ctx.SaveChanges();
                }
                ctx.Clients.Add(client);
                ctx.SaveChanges();
            }
        }

        private bool GetByRef(Guid guid)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                return ctx.Clients.Any(k => k.client_id == guid);
            }

        }

        public void SaveBranch(Branch branch)
        {

            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Branch.FirstOrDefault(k => k.client_id == branch.client_id && k.o_id == branch.o_id);
                if (stored != null)
                {
                    ctx.Entry(branch).State = EntityState.Modified;
                    ctx.SaveChanges();
                }

                ctx.Branch.Add(branch);
                ctx.SaveChanges();
            }

        }

        public void SaveChangingInfo(ChangingInfo changingInfo)
        {

            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.ChangingInfo.FirstOrDefault(k => k.client_id == changingInfo.client_id && k.o_id == changingInfo.o_id);
                if (stored != null)
                {
                    ctx.Entry(changingInfo).State = EntityState.Modified;
                    ctx.SaveChanges();
                }

                ctx.ChangingInfo.Add(changingInfo);
                ctx.SaveChanges();
            }
        }

        public void SaveCart(Cart cart)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Cart.FirstOrDefault(k => k.client_id == cart.client_id && k.o_id == cart.o_id);
                if (stored != null)
                {
                    ctx.Entry(cart).State = EntityState.Modified;
                    ctx.SaveChanges();
                }

                ctx.Cart.Add(cart);
                ctx.SaveChanges();
            }
        }

        public void SaveCategory(Category category)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Category.FirstOrDefault(k => k.client_id == category.client_id && k.o_id == category.o_id);
                if (stored != null)
                {
                    ctx.Entry(category).State = EntityState.Modified;
                    ctx.SaveChanges();
                }

                ctx.Category.Add(category);
                ctx.SaveChanges();
            }
        }

        public void SaveInvoice(Invoice invoice)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Invoice.FirstOrDefault(k => k.client_id == invoice.client_id && k.o_id == invoice.o_id);
                if (stored != null)
                {
                    ctx.Entry(invoice).State = EntityState.Modified;
                    ctx.SaveChanges();
                }

                ctx.Invoice.Add(invoice);
                ctx.SaveChanges();
            }

        }

        public void SaveInvoicedProduct(InvoicedProduct invoicedProduct)
        {
            InvoicedProduct stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.InvoicedProduct.FirstOrDefault(k => k.client_id == invoicedProduct.client_id && k.o_id == invoicedProduct.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.InvoicedProduct.Add(invoicedProduct);
                    ctx.SaveChanges();
                }

            stored = invoicedProduct;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }



        }

        public void SavePersonalInfo(PersonalInfo personalInfo)
        {
            PersonalInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.PersonalInfo.FirstOrDefault(k => k.client_id == personalInfo.client_id && k.o_id == personalInfo.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.PersonalInfo.Add(personalInfo);
                    ctx.SaveChanges();
                }

            stored = personalInfo;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }



        }

        public void SaveUserGreenNoteImport(GreenNoteImports gnote_imports)
        {
            GreenNoteImports stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.GreenNoteImports.FirstOrDefault(k => k.client_id == gnote_imports.client_id && k.o_id == gnote_imports.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.GreenNoteImports.Add(gnote_imports);
                    ctx.SaveChanges();
                }

            stored = gnote_imports;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProductAvailableBranch(ProductAvailableBranch productAvailableBranch)
        {
            ProductAvailableBranch stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ProductAvailableBranch.FirstOrDefault(k => k.client_id == productAvailableBranch.client_id && k.o_id == productAvailableBranch.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ProductAvailableBranch.Add(productAvailableBranch);
                    ctx.SaveChanges();
                }

            stored = productAvailableBranch;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProduct(Product product)
        {
            Product stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.Product.FirstOrDefault(k => k.client_id == product.client_id && k.o_id == product.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.Product.Add(product);
                    ctx.SaveChanges();
                }

            stored = product;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProductCategory(ProductCategory productCategory)
        {
            ProductCategory stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ProductCategory.FirstOrDefault(k => k.client_id == productCategory.client_id && k.o_id == productCategory.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ProductCategory.Add(productCategory);
                    ctx.SaveChanges();
                }

            stored = productCategory;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProductImage(ProductImage productImage)
        {
            ProductImage stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ProductImage.FirstOrDefault(k => k.client_id == productImage.client_id && k.o_id == productImage.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ProductImage.Add(productImage);
                    ctx.SaveChanges();
                }

            stored = productImage;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveRetailerBranch(RetailerBranch retailerBranch)
        {
            RetailerBranch stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.RetailerBranch.FirstOrDefault(k => k.client_id == retailerBranch.client_id && k.o_id == retailerBranch.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.RetailerBranch.Add(retailerBranch);
                    ctx.SaveChanges();
                }

            stored = retailerBranch;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveRetailerInfo(RetailerInfo retailerInfo)
        {
            RetailerInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.RetailerInfo.FirstOrDefault(k => k.client_id == retailerInfo.client_id && k.o_id == retailerInfo.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.RetailerInfo.Add(retailerInfo);
                    ctx.SaveChanges();
                }

            stored = retailerInfo;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveSubscriberInfo(SubscriberInfo subscriberInfo)
        {
            SubscriberInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.SubscriberInfo.FirstOrDefault(k => k.client_id == subscriberInfo.client_id && k.o_id == subscriberInfo.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.SubscriberInfo.Add(subscriberInfo);
                    ctx.SaveChanges();
                }

            stored = subscriberInfo;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveUserAccount(UserAccount userAccount)
        {
            UserAccount stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.UserAccount.FirstOrDefault(k => k.client_id == userAccount.client_id && k.o_id == userAccount.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.UserAccount.Add(userAccount);
                    ctx.SaveChanges();
                }

            stored = userAccount;
            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}