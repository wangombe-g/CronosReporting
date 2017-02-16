namespace CronReporting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addOwnerToGnote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GreenNoteImports", "owner", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GreenNoteImports", "owner");
        }
    }
}
