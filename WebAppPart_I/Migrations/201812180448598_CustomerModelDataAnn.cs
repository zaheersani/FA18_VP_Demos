namespace WebAppPart_I.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModelDataAnn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
