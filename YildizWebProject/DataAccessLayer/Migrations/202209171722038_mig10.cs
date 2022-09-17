namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        businessId = c.Int(nullable: false, identity: true),
                        businessName = c.String(),
                        businessDescription = c.String(),
                    })
                .PrimaryKey(t => t.businessId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        customerName = c.String(),
                        customerLastName = c.String(),
                        customerMail = c.String(),
                        customerPhoneNumber = c.String(),
                        customerMessage = c.String(),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        mediaId = c.Int(nullable: false, identity: true),
                        mediaName = c.String(),
                    })
                .PrimaryKey(t => t.mediaId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        projectId = c.Int(nullable: false, identity: true),
                        projectName = c.String(),
                        projectDescription = c.String(),
                        mediaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.projectId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
            DropTable("dbo.Media");
            DropTable("dbo.Contacts");
            DropTable("dbo.Businesses");
        }
    }
}
