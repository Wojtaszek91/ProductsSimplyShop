namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeDatesNullableInOrderDomainModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderModels", "deliveredDate", c => c.DateTime());
            AlterColumn("dbo.OrderModels", "payedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderModels", "payedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OrderModels", "deliveredDate", c => c.DateTime(nullable: false));
        }
    }
}
