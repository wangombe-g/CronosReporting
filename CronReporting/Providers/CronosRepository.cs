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
            using (var ctx = new CronosContext(_contextConnection))
            {
                if (GetByRef(client.client_id))
                {
                    client.last_sync_date = client.last_sync_date;
                    client.sync_date = DateTime.Now;
                    return ctx.SaveChanges();
                }
                ctx.Clients.Add(client);
                return ctx.SaveChanges();
            }
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
                var stored = ctx.Branch.FirstOrDefault(k => k.client_id == branch.client_id && k.o_id == branch.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(branch);
                        return ctx.SaveChanges();
                    }
                }

                ctx.Branch.Add(branch);
                return ctx.SaveChanges();
            }

        }
        public int SaveChangingInfo(ChangingInfo changingInfo)
        {

            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.ChangingInfo.FirstOrDefault(k => k.client_id == changingInfo.client_id && k.o_id == changingInfo.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(changingInfo);
                        return ctx.SaveChanges();
                    }
                }

                ctx.ChangingInfo.Add(changingInfo);
                return ctx.SaveChanges();
            }
        }

        public int SaveCart(Cart cart)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Cart.FirstOrDefault(k => k.client_id == cart.client_id && k.o_id == cart.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(cart);
                        return ctx.SaveChanges();
                    }
                }

                ctx.Cart.Add(cart);
                return ctx.SaveChanges();
            }
        }

        public int SaveCategory(Category category)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Category.FirstOrDefault(k => k.client_id == category.client_id && k.o_id == category.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(category);
                        return ctx.SaveChanges();
                    }
                }

                ctx.Category.Add(category);
                return ctx.SaveChanges();
            }
        }

        public int SaveInvoice(Invoice invoice)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Invoice.FirstOrDefault(k => k.client_id == invoice.client_id && k.o_id == invoice.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(invoice);
                        return ctx.SaveChanges();
                    }
                }

                ctx.Invoice.Add(invoice);
                return ctx.SaveChanges();
            }

        }
        public int SaveInvoicedProduct(InvoicedProduct invoicedProduct)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.InvoicedProduct.FirstOrDefault(k => k.client_id == invoicedProduct.client_id && k.o_id == invoicedProduct.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(invoicedProduct);
                        return ctx.SaveChanges();
                    }
                }

                ctx.InvoicedProduct.Add(invoicedProduct);
                return ctx.SaveChanges();
            }

        }

        public int SavePersonalInfo(PersonalInfo personalInfo)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.PersonalInfo.FirstOrDefault(k => k.client_id == personalInfo.client_id && k.o_id == personalInfo.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(personalInfo);
                        return ctx.SaveChanges();
                    }
                }

                ctx.PersonalInfo.Add(personalInfo);
                return ctx.SaveChanges();
            }
        }

        public int SaveUserGreenNoteImport(GreenNoteImports gnote_imports)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.GreenNoteImports.FirstOrDefault(k => k.client_id == gnote_imports.client_id && k.o_id == gnote_imports.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(gnote_imports);
                        return ctx.SaveChanges();
                    }
                }

                ctx.GreenNoteImports.Add(gnote_imports);
                return ctx.SaveChanges();
            }
        }

        public int SaveProductAvailableBranch(ProductAvailableBranch productAvailableBranch)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.ProductAvailableBranch.FirstOrDefault(k => k.client_id == productAvailableBranch.client_id && k.o_id == productAvailableBranch.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(productAvailableBranch);
                        return ctx.SaveChanges();
                    }
                }

                ctx.ProductAvailableBranch.Add(productAvailableBranch);
                return ctx.SaveChanges();
            }

        }

        public int SavProductCategory(ProductCategory productCategory)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.ProductCategory.FirstOrDefault(k => k.client_id == productCategory.client_id && k.o_id == productCategory.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(productCategory);
                        return ctx.SaveChanges();
                    }
                }

                ctx.ProductCategory.Add(productCategory);
                return ctx.SaveChanges();
            }
        }
        public int SaveProduct(Product product)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.Product.FirstOrDefault(k => k.client_id == product.client_id && k.o_id == product.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(product);
                        return ctx.SaveChanges();
                    }
                }

                ctx.Product.Add(product);
                return ctx.SaveChanges();
            }
        }

        public int SaveProductCategory(ProductCategory productCategory)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.ProductCategory.FirstOrDefault(k => k.client_id == productCategory.client_id && k.o_id == productCategory.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(productCategory);
                        return ctx.SaveChanges();
                    }
                }

                ctx.ProductCategory.Add(productCategory);
                return ctx.SaveChanges();
            }
        }

        public int SaveProductImage(ProductImage productImage)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.ProductImage.FirstOrDefault(k => k.client_id == productImage.client_id && k.o_id == productImage.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(productImage);
                        return ctx.SaveChanges();
                    }
                }

                ctx.ProductImage.Add(productImage);
                return ctx.SaveChanges();
            }

        }

        public int SaveRetailerBranch(RetailerBranch retailerBranch)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.RetailerBranch.FirstOrDefault(k => k.client_id == retailerBranch.client_id && k.o_id == retailerBranch.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(retailerBranch);
                        return ctx.SaveChanges();
                    }
                }

                ctx.RetailerBranch.Add(retailerBranch);
                return ctx.SaveChanges();
            }
        }
        public int SaveRetailerInfo(RetailerInfo retailerInfo)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.RetailerInfo.FirstOrDefault(k => k.client_id == retailerInfo.client_id && k.o_id == retailerInfo.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(retailerInfo);
                        return ctx.SaveChanges();
                    }
                }

                ctx.RetailerInfo.Add(retailerInfo);
                return ctx.SaveChanges();
            }

        }

        public int SaveSubscriberInfo(SubscriberInfo subscriberInfo)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.SubscriberInfo.FirstOrDefault(k => k.client_id == subscriberInfo.client_id && k.o_id == subscriberInfo.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(subscriberInfo);
                        return ctx.SaveChanges();
                    }
                }

                ctx.SubscriberInfo.Add(subscriberInfo);
                return ctx.SaveChanges();
            }
        }

        public int SaveUserAccount(UserAccount userAccount)
        {
            using (var ctx = new CronosContext(_contextConnection))
            {
                var stored = ctx.UserAccount.FirstOrDefault(k => k.client_id == userAccount.client_id && k.o_id == userAccount.o_id);
                if (stored != null)
                {
                    var entity = ctx.Branch.Find(stored.id);
                    if (entity != null)
                    {
                        ctx.Entry(entity).CurrentValues.SetValues(userAccount);
                        return ctx.SaveChanges();
                    }
                }

                ctx.UserAccount.Add(userAccount);
                return ctx.SaveChanges();
            }
        }
    }
}