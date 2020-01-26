namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
