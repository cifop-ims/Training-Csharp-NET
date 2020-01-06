namespace CodeFirstFromExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateColumnToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Date");
        }
    }
}
