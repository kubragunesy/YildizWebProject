namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "statu", c => c.Boolean(nullable: false));
            AddColumn("dbo.Contacts", "statu", c => c.Boolean(nullable: false));
            AddColumn("dbo.Media", "statu", c => c.Boolean(nullable: false));
            AddColumn("dbo.Projects", "statu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "statu");
            DropColumn("dbo.Media", "statu");
            DropColumn("dbo.Contacts", "statu");
            DropColumn("dbo.Businesses", "statu");
        }
    }
}
