namespace WebAppPart_I.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Cars", "Order_ID", c => c.Int());
            AddColumn("dbo.Customers", "Order_ID", c => c.Int());
            CreateIndex("dbo.Cars", "Order_ID");
            CreateIndex("dbo.Customers", "Order_ID");
            AddForeignKey("dbo.Cars", "Order_ID", "dbo.Orders", "ID");
            AddForeignKey("dbo.Customers", "Order_ID", "dbo.Orders", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Cars", "Order_ID", "dbo.Orders");
            DropIndex("dbo.Customers", new[] { "Order_ID" });
            DropIndex("dbo.Cars", new[] { "Order_ID" });
            DropColumn("dbo.Customers", "Order_ID");
            DropColumn("dbo.Cars", "Order_ID");
            DropTable("dbo.Orders");
        }
    }
}
