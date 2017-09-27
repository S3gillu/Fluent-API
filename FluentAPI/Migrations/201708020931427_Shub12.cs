namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Project_Head", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Project_Head", c => c.String());
        }
    }
}
