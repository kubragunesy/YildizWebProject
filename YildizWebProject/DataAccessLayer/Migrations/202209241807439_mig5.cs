namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        aboutId = c.Int(nullable: false, identity: true),
                        aboutName = c.String(),
                        aboutDescription = c.String(),
                    })
                .PrimaryKey(t => t.aboutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
