namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedOrderModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "OrderModel_Id", "dbo.OrderModels");
            DropIndex("dbo.Products", new[] { "OrderModel_Id" });
            AddColumn("dbo.OrderModels", "product_Id", c => c.Int());
            CreateIndex("dbo.OrderModels", "product_Id");
            AddForeignKey("dbo.OrderModels", "product_Id", "dbo.Products", "Id");
            DropColumn("dbo.Products", "OrderModel_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OrderModel_Id", c => c.Int());
            DropForeignKey("dbo.OrderModels", "product_Id", "dbo.Products");
            DropIndex("dbo.OrderModels", new[] { "product_Id" });
            DropColumn("dbo.OrderModels", "product_Id");
            CreateIndex("dbo.Products", "OrderModel_Id");
            AddForeignKey("dbo.Products", "OrderModel_Id", "dbo.OrderModels", "Id");
        }
    }
}
