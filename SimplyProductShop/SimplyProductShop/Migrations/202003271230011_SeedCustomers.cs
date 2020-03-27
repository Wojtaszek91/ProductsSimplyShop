namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
            Sql("INSERT INTO Customers (name) VALUES ('FirstCustomer')");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Name");
        }
    }
}
