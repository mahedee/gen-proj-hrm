namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedept : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Depts", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Depts", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Depts", "Create_Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Depts", "Create_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Depts", "Name", c => c.String());
            DropColumn("dbo.Depts", "CreateDate");
        }
    }
}
