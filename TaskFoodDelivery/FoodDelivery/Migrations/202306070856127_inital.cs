namespace FoodDelivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dishes", "Grammage", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dishes", "Grammage", c => c.Int(nullable: false));
        }
    }
}
