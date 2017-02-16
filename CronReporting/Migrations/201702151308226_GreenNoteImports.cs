namespace CronReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GreenNoteImports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GreenNoteImports",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        o_id = c.Int(nullable: false),
                        client_id = c.Guid(nullable: false),
                        product_id = c.String(),
                        gnote_number = c.String(),
                        warehouse = c.String(),
                        location = c.String(),
                        expiry_date = c.String(),
                        catalog = c.String(),
                        grade = c.String(),
                        weight = c.String(),
                        reserve_price = c.String(),
                        close_date = c.String(),
                        bids = c.String(),
                        status = c.String(),
                        created = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GreenNoteImports");
        }
    }
}
