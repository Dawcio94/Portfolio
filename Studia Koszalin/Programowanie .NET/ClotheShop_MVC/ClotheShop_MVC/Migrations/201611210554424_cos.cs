namespace ClotheShop_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCarts", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCarts", "UserName");
        }
    }
}
