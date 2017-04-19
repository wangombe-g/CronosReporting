using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CronReporting.Models
{
    public class Database
    {
        public string client { get; set; }
        public Guid client_id { get; set; }
        public DateTime last_sync_date { get; set; }
        public DateTime sync_date { get; set; }
        public Tables tables { get; set; }
    }

    public class Clients
    {
        [Key]
        public int id { get; set; }
        public string client { get; set; }
        public Guid client_id { get; set; }
        public DateTime last_sync_date { get; set; }
        public DateTime sync_date { get; set; }
    }

    public class Branch
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }
        public Guid client_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
        public string status { get; set; }
    }

    public class Cart
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public int no_of_units { get; set; }
        public DateTime added_time { get; set; }
        public string status { get; set; }
        public DateTime created_date { get; set; }
        public DateTime last_modified_date { get; set; }
    }

    public class Category
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public string name { get; set; }
        public int? parent_category_id { get; set; }
        public string description { get; set; }
        public string created_date { get; set; }
        public string DateTime { get; set; }
        public string status { get; set; }
    }

    public class ChangingInfo
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int invoice_id { get; set; }
        public object tx_id { get; set; }
        public string type { get; set; }
        public string long_description { get; set; }
        public string short_description { get; set; }
        public DateTime created_date { get; set; }
        public DateTime last_modified_date { get; set; }
    }

    public class InvoicedProduct
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int invoice_id { get; set; }
        public int product_id { get; set; }
        public int no_of_units { get; set; }
        public int is_delivery_required { get; set; }
        public string status { get; set; }
        public DateTime delivered_or_issued_date { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }

    public class Invoice
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public string invoice_no { get; set; }
        public int user_id { get; set; }
        public string session_id { get; set; }
        public string channel { get; set; }
        public string payment_instrument { get; set; }
        public string account_id { get; set; }
        public string delivery_address { get; set; }
        public string status { get; set; }
        public string sub_total { get; set; }
        public int? service_charges { get; set; }
        public string currency { get; set; }
        public DateTime invoiced_time { get; set; }
        public string retailer_updated_time { get; set; }
        public string contact_person { get; set; }
        public string contact_no { get; set; }
        public int transport_fare { get; set; }
        public int? total_amount { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }

    public class PersonalInfo
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }

        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string profession { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_modified { get; set; }
    }

    public class Product
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price_amount { get; set; }
        public string currency { get; set; }
        public int is_in_stock { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
        public string status { get; set; }
    }

    public class ProductAvailableBranch
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int product_id { get; set; }
        public int branch_id { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }

    public class ProductCategory
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int product_id { get; set; }
        public int category_id { get; set; }
        public int is_default { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }

    public class ProductImage
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int product_id { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }

    public class RetailerBranch
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int user_id { get; set; }
        public int branch_id { get; set; }
        public DateTime last_modified_date { get; set; }
        public DateTime created_date { get; set; }
    }

    public class RetailerInfo
    {
        public int o_id { get; set; }

        [Key]
        public int id { get; set; }

        public Guid client_id { get; set; }
        public int user_id { get; set; }
        public int po_notify_required { get; set; }
        public string po_notify_method { get; set; }
        public object email { get; set; }
        public string msisdn { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_modified { get; set; }
    }

    public class UserAccount
    {
        [Key]
        public int id { get; set; }

        public Guid user_name { get; set; }
        public string password { get; set; }
        public string user_type { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_modified { get; set; }
        public string client_id { get; set; }
        public int o_id { get; set; }
    }

    public class SubscriberInfo
    {
        public int o_id { get; set; }
        [Key]
        public int id { get; set; }
        public Guid client_id { get; set; }
        public int user_id { get; set; }
        public string mpin { get; set; }
        public string year_of_birth { get; set; }
        public string msisdn { get; set; }
        public string mothers_maiden_name { get; set; }
        public string identity_no { get; set; }
        public string verification_code { get; set; }
        public int? verification_codes_sent { get; set; }
        public DateTime last_verified_code_sent_time { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_modified { get; set; }
    }

    public class SmsReceived
    {
        [Key]
        public int id { get; set; }
        public string msisdn { get; set; }
        public string message { get; set; }
        public string message_type { get; set; }
        public string group { get; set; }
        public string status { get; set; }
        public DateTime created { get; set; }
        public Guid client_id { get; set; }
        public int o_id { get; set; }
    }

    public class GreenNoteImports
    {
        public int o_id { get; set; }
        [Key]
        public int id { get; set; }
        public Guid client_id { get; set; }
        public string product_id { get; set; }
        public string owner { get; set; }
        public string gnote_number { get; set; }
        public string warehouse { get; set; }
        public string location { get; set; }
        public string expiry_date { get; set; }
        public string catalog { get; set; }
        public string grade { get; set; }
        public string weight { get; set; }
        public string reserve_price { get; set; }
        public string close_date { get; set; }
        public string bids { get; set; }
        public string status { get; set; }
        public string created { get; set; }
    }

    public class Tables
    {
        public List<Branch> branch { get; set; }
        public List<Cart> cart { get; set; }
        public List<Category> category { get; set; }
        public List<ChangingInfo> changing_info { get; set; }
        public List<InvoicedProduct> invoiced_products { get; set; }
        public List<Invoice> invoice { get; set; }
        public List<PersonalInfo> personal_info { get; set; }
        public List<Product> product { get; set; }
        public List<ProductAvailableBranch> product_available_branch { get; set; }
        public List<ProductCategory> product_category { get; set; }
        public List<ProductImage> product_image { get; set; }
        public List<RetailerBranch> retailer_branches { get; set; }
        public List<RetailerInfo> retailer_info { get; set; }
        public List<SubscriberInfo> subscriber_info { get; set; }
        public List<UserAccount> user_account { get; set; }
        public List<GreenNoteImports> gnote_imports { get; set; }
        public List<SmsReceived> sms_received { get; set; }
    }
}