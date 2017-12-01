namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddesignation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DeptId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depts", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Designations", "DeptId", "dbo.Depts");
            DropIndex("dbo.Designations", new[] { "DeptId" });
            DropTable("dbo.Designations");
        }
    }
}
