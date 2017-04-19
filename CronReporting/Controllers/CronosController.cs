using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CronReporting.Models;
using CronReporting.Providers;
using Newtonsoft.Json;

namespace CronReporting.Controllers
{
    public class CronosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api/cronos")]
        public HttpResponseMessage Post([FromBody]Database database)
        {
            var cronosRepository = new CronosRepository();
            database.tables.branch?.ForEach(branch => cronosRepository.SaveBranch(branch));
            database.tables.cart?.ForEach(cart => cronosRepository.SaveCart(cart));
            database.tables.category?.ForEach(category => cronosRepository.SaveCategory(category));
            database.tables.changing_info?.ForEach(changing_info => cronosRepository.SaveChangingInfo(changing_info));
            database.tables.invoiced_products?.ForEach(invoiced_products => cronosRepository.SaveInvoicedProduct(invoiced_products));
            database.tables.invoice?.ForEach(invoice => cronosRepository.SaveInvoice(invoice));
            database.tables.personal_info?.ForEach(personal_info => cronosRepository.SavePersonalInfo(personal_info));
            database.tables.product?.ForEach(product => cronosRepository.SaveProduct(product));
            database.tables.product_available_branch?.ForEach(product_available_branch => cronosRepository.SaveProductAvailableBranch(product_available_branch));
            database.tables.product_category?.ForEach(product_category => cronosRepository.SaveProductCategory(product_category));
            database.tables.product_image?.ForEach(product_image => cronosRepository.SaveProductImage(product_image));
            database.tables.retailer_info?.ForEach(retailer_info => cronosRepository.SaveRetailerInfo(retailer_info));
            database.tables.retailer_branches?.ForEach(retailer_branch => cronosRepository.SaveRetailerBranch(retailer_branch));
            database.tables.subscriber_info?.ForEach(subscriber_info => cronosRepository.SaveSubscriberInfo(subscriber_info));
            database.tables.user_account?.ForEach(user_account => cronosRepository.SaveUserAccount(user_account));
            database.tables.gnote_imports?.ForEach(gnote_imports => cronosRepository.SaveUserGreenNoteImport(gnote_imports));
            database.tables.sms_received?.ForEach(sms_received => cronosRepository.SaveSmsReceived(sms_received));
            var nullDate = new DateTime();
            cronosRepository.SaveClients(new Clients
            {
                client_id = database.client_id,
                client = database.client,
                last_sync_date = database.last_sync_date == nullDate ? DateTime.Now : database.last_sync_date,
                sync_date = database.sync_date
            });

            return new HttpResponseMessage(HttpStatusCode.OK);
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        
    }
   
}