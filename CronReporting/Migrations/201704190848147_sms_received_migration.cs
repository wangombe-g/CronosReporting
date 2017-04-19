namespace CronReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sms_received_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SmsReceiveds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        msisdn = c.String(),
                        message = c.String(),
                        message_type = c.String(),
                        group = c.String(),
                        status = c.String(),
                        created = c.DateTime(nullable: false),
                        client_id = c.Guid(nullable: false),
                        o_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SmsReceiveds");
        }
    }
}
