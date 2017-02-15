namespace CronReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMissingTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        name = c.String(),
                        address = c.String(),
                        description = c.String(),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        user_id = c.Int(nullable: false),
                        product_id = c.Int(nullable: false),
                        no_of_units = c.Int(nullable: false),
                        added_time = c.DateTime(nullable: false),
                        status = c.String(),
                        created_date = c.DateTime(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        name = c.String(),
                        parent_category_id = c.Int(),
                        description = c.String(),
                        created_date = c.String(),
                        DateTime = c.String(),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ChangingInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        invoice_id = c.Int(nullable: false),
                        type = c.String(),
                        long_description = c.String(),
                        short_description = c.String(),
                        created_date = c.DateTime(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        client = c.String(),
                        client_id = c.Guid(nullable: false),
                        last_sync_date = c.DateTime(nullable: false),
                        sync_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        invoice_no = c.String(),
                        user_id = c.Int(nullable: false),
                        session_id = c.String(),
                        channel = c.String(),
                        payment_instrument = c.String(),
                        account_id = c.String(),
                        delivery_address = c.String(),
                        status = c.String(),
                        sub_total = c.String(),
                        service_charges = c.Int(),
                        currency = c.String(),
                        invoiced_time = c.DateTime(nullable: false),
                        retailer_updated_time = c.String(),
                        contact_person = c.String(),
                        contact_no = c.String(),
                        transport_fare = c.Int(nullable: false),
                        total_amount = c.Int(),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InvoicedProducts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        invoice_id = c.Int(nullable: false),
                        product_id = c.Int(nullable: false),
                        no_of_units = c.Int(nullable: false),
                        is_delivery_required = c.Int(nullable: false),
                        status = c.String(),
                        delivered_or_issued_date = c.DateTime(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PersonalInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        user_id = c.Int(nullable: false),
                        first_name = c.String(),
                        last_name = c.String(),
                        address = c.String(),
                        state = c.String(),
                        province = c.String(),
                        country = c.String(),
                        profession = c.String(),
                        created_at = c.DateTime(nullable: false),
                        last_modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        name = c.String(),
                        description = c.String(),
                        price_amount = c.Int(nullable: false),
                        currency = c.String(),
                        is_in_stock = c.Int(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProductAvailableBranches",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        product_id = c.Int(nullable: false),
                        branch_id = c.Int(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        product_id = c.Int(nullable: false),
                        category_id = c.Int(nullable: false),
                        is_default = c.Int(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        product_id = c.Int(nullable: false),
                        type = c.String(),
                        url = c.String(),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RetailerBranches",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        user_id = c.Int(nullable: false),
                        branch_id = c.Int(nullable: false),
                        last_modified_date = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RetailerInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        user_id = c.Int(nullable: false),
                        po_notify_required = c.Int(nullable: false),
                        po_notify_method = c.String(),
                        msisdn = c.String(),
                        created_at = c.DateTime(nullable: false),
                        last_modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SubscriberInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        user_id = c.Int(nullable: false),
                        mpin = c.String(),
                        year_of_birth = c.String(),
                        msisdn = c.String(),
                        mothers_maiden_name = c.String(),
                        identity_no = c.String(),
                        verification_code = c.String(),
                        verification_codes_sent = c.Int(),
                        last_verified_code_sent_time = c.DateTime(nullable: false),
                        created_at = c.DateTime(nullable: false),
                        last_modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_name = c.Guid(nullable: false),
                        password = c.String(),
                        user_type = c.String(),
                        status = c.String(),
                        created_at = c.DateTime(nullable: false),
                        last_modified = c.DateTime(nullable: false),
                        client_id = c.String(),
                        o_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAccounts");
            DropTable("dbo.SubscriberInfoes");
            DropTable("dbo.RetailerInfoes");
            DropTable("dbo.RetailerBranches");
            DropTable("dbo.ProductImages");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.ProductAvailableBranches");
            DropTable("dbo.Products");
            DropTable("dbo.PersonalInfoes");
            DropTable("dbo.InvoicedProducts");
            DropTable("dbo.Invoices");
            DropTable("dbo.Clients");
            DropTable("dbo.ChangingInfoes");
            DropTable("dbo.Categories");
            DropTable("dbo.Carts");
            DropTable("dbo.Branches");
        }
    }
}
