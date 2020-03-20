namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateProducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (name, description, img, isAvaliable, Category) VALUES ('Wonderwoman', 'She will wonder you more than once ! Its a Wonderwoman !', 'none',1,'FullSuit')");
            Sql("INSERT INTO Products (name, description, img, isAvaliable, Category) VALUES ('Spiderman', 'Who is walking on your walls ? ! Its a Spiderman !', 'none',1,'FullSuit')");
        }
        
        public override void Down()
        {
        }
    }
}
