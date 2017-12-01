namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addednotice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        PublishDate = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        ApproveBy = c.String(),
                        ApproveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notices");
        }
    }
}
