namespace SimplyProductShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e784910-a2e9-41bd-8cef-e45f30688136', N'admin@app.com', 0, N'ABYqkq0c6kT5AaF4tF+MA2+nKpnW81N/AzcrO077BeBjBmWUTZGj7rgSa/v8OFATww==', N'952e7d7c-7f31-42f4-89d6-ea0121107c3e', NULL, 0, 0, NULL, 1, 0, N'admin@app.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd1c68685-16de-4453-8490-03974ca0f018', N'guest@app.com', 0, N'AGDqcqqo0nBhjdv9/Le2LNT5RdN1XnX9YqzIgCsIf+gfzeOwXpP6pPN5Ri+bd8tylQ==', N'9530abbe-f0a2-4008-9e69-05578c41fad1', NULL, 0, 0, NULL, 1, 0, N'guest@app.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4177bdb1-06e7-4f64-9e34-54aad919f079', N'CanManageProducts')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e784910-a2e9-41bd-8cef-e45f30688136', N'4177bdb1-06e7-4f64-9e34-54aad919f079')

");
        }
        
        public override void Down()
        {
        }
    }
}
