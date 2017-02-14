using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CronReporting.Models
{
    public class Database
    {
        public string client { get; set; }
        public string client_id { get; set; }
        public DateTime last_sync_date { get; set; }
        public DateTime sync_date { get; set; }
        public Tables tables { get; set; }
    }

    public class Branch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
        public string status { get; set; }
    }

    public class Cart
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public int no_of_units { get; set; }
        public string added_time { get; set; }
        public string status { get; set; }
        public string created_date { get; set; }
        public string last_modified_date { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? parent_category_id { get; set; }
        public string description { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
        public string status { get; set; }
    }

    public class ChangingInfo
    {
        public int id { get; set; }
        public int invoice_id { get; set; }
        public object tx_id { get; set; }
        public string type { get; set; }
        public string long_description { get; set; }
        public object short_description { get; set; }
        public string created_date { get; set; }
        public string last_modified_date { get; set; }
    }

    public class InvoicedProduct
    {
        public int id { get; set; }
        public int invoice_id { get; set; }
        public int product_id { get; set; }
        public int no_of_units { get; set; }
        public int is_delivery_required { get; set; }
        public string status { get; set; }
        public string delivered_or_issued_date { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
    }

    public class Invoice
    {
        public int id { get; set; }
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
        public string invoiced_time { get; set; }
        public string retailer_updated_time { get; set; }
        public string contact_person { get; set; }
        public string contact_no { get; set; }
        public int transport_fare { get; set; }
        public int? total_amount { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
    }

    public class PersonalInfo
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string profession { get; set; }
        public string created_at { get; set; }
        public string last_modified { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price_amount { get; set; }
        public string currency { get; set; }
        public int is_in_stock { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
        public string status { get; set; }
    }

    public class ProductAvailableBranch
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int branch_id { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
    }

    public class ProductCategory
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int category_id { get; set; }
        public int is_default { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
    }

    public class ProductImage
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
    }

    public class RetailerBranch
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int branch_id { get; set; }
        public string last_modified_date { get; set; }
        public string created_date { get; set; }
    }

    public class RetailerInfo
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int po_notify_required { get; set; }
        public string po_notify_method { get; set; }
        public object email { get; set; }
        public string msisdn { get; set; }
        public string created_at { get; set; }
        public string last_modified { get; set; }
    }

    public class SubscriberInfo
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string mpin { get; set; }
        public string year_of_birth { get; set; }
        public string msisdn { get; set; }
        public string mothers_maiden_name { get; set; }
        public string identity_no { get; set; }
        public string verification_code { get; set; }
        public int? verification_codes_sent { get; set; }
        public string last_verified_code_sent_time { get; set; }
        public string created_at { get; set; }
        public string last_modified { get; set; }
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
    }


}