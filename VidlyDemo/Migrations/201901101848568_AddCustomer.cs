namespace VidlyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Int(nullable: false));
        }
    }
}
