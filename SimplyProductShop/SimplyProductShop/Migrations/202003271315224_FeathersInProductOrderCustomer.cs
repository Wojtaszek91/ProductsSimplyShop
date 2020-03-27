namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FeathersInProductOrderCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderModels", "product_Id", "dbo.Products");
            DropIndex("dbo.OrderModels", new[] { "product_Id" });
            AddColumn("dbo.Products", "OrderModel_Id", c => c.Int());
            CreateIndex("dbo.Products", "OrderModel_Id");
            AddForeignKey("dbo.Products", "OrderModel_Id", "dbo.OrderModels", "Id");
            DropColumn("dbo.OrderModels", "product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderModels", "product_Id", c => c.Int());
            DropForeignKey("dbo.Products", "OrderModel_Id", "dbo.OrderModels");
            DropIndex("dbo.Products", new[] { "OrderModel_Id" });
            DropColumn("dbo.Products", "OrderModel_Id");
            CreateIndex("dbo.OrderModels", "product_Id");
            AddForeignKey("dbo.OrderModels", "product_Id", "dbo.Products", "Id");
        }
    }
}
