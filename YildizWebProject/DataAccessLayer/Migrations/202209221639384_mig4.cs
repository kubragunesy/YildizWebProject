namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "password", c => c.String(maxLength: 20));
            AlterColumn("dbo.Admins", "adminRole", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "adminRole", c => c.String());
            AlterColumn("dbo.Admins", "password", c => c.String());
        }
    }
}
