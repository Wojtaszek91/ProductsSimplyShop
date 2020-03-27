namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderModelAndSkeletonOfCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        orderDate = c.DateTime(nullable: false),
                        deliveredDate = c.DateTime(nullable: false),
                        payedDate = c.DateTime(nullable: false),
                        isPayed = c.Boolean(nullable: false),
                        isDelivered = c.Boolean(nullable: false),
                        customer_Id = c.Int(),
                        product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.customer_Id)
                .ForeignKey("dbo.Products", t => t.product_Id)
                .Index(t => t.customer_Id)
                .Index(t => t.product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderModels", "product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderModels", "customer_Id", "dbo.Customers");
            DropIndex("dbo.OrderModels", new[] { "product_Id" });
            DropIndex("dbo.OrderModels", new[] { "customer_Id" });
            DropTable("dbo.OrderModels");
            DropTable("dbo.Customers");
        }
    }
}
