namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Project_Name", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Project_Name", c => c.String());
        }
    }
}
