namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryPropertyToProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductModels", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductModels", "Category");
        }
    }
}
