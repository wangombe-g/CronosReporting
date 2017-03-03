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

        public void SaveBranch(Branch newItem)
        {

            Branch stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.Branch.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.Branch.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(newItem).State = EntityState.Modified;
                ctx.SaveChanges();
            }

        }

        public void SaveChangingInfo(ChangingInfo newItem)
        {

            ChangingInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ChangingInfo.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ChangingInfo.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(newItem).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveCart(Cart newItem)
        {
            Cart stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.Cart.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.Cart.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(newItem).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveCategory(Category newItem)
        {
            Category stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.Category.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.Category.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(newItem).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveInvoice(Invoice newItem)
        {
            Invoice stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.Invoice.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.Invoice.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(newItem).State = EntityState.Modified;
                ctx.SaveChanges();
            }

        }

        public void SaveInvoicedProduct(InvoicedProduct newItem)
        {
            InvoicedProduct stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.InvoicedProduct.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.InvoicedProduct.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(newItem).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SavePersonalInfo(PersonalInfo newItem)
        {
            PersonalInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.PersonalInfo.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.PersonalInfo.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }



        }

        public void SaveUserGreenNoteImport(GreenNoteImports newItem)
        {
            GreenNoteImports stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.GreenNoteImports.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.GreenNoteImports.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProductAvailableBranch(ProductAvailableBranch newItem)
        {
            ProductAvailableBranch stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ProductAvailableBranch.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ProductAvailableBranch.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProduct(Product newItem)
        {
            Product stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.Product.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.Product.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProductCategory(ProductCategory newItem)
        {
            ProductCategory stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ProductCategory.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ProductCategory.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveProductImage(ProductImage newItem)
        {
            ProductImage stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.ProductImage.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.ProductImage.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveRetailerBranch(RetailerBranch newItem)
        {
            RetailerBranch stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.RetailerBranch.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.RetailerBranch.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveRetailerInfo(RetailerInfo newItem)
        {
            RetailerInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.RetailerInfo.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.RetailerInfo.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveSubscriberInfo(SubscriberInfo newItem)
        {
            SubscriberInfo stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.SubscriberInfo.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.SubscriberInfo.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void SaveUserAccount(UserAccount newItem)
        {
            UserAccount stored;
            using (var ctx = new CronosContext(_contextConnection))
                stored = ctx.UserAccount.FirstOrDefault(k => k.client_id == newItem.client_id && k.o_id == newItem.o_id);

            if (stored == null)
                using (var ctx = new CronosContext(_contextConnection))
                {
                    ctx.UserAccount.Add(newItem);
                    ctx.SaveChanges();
                }

            if (stored != null) newItem.id = stored.id;

            using (var ctx = new CronosContext(_contextConnection))
            {
                ctx.Entry(stored).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}