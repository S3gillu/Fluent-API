namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Engineers", "Eng_Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Projects", "Project_Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Projects", "Project_Head", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Project_Head", c => c.String(maxLength: 200));
            AlterColumn("dbo.Projects", "Project_Name", c => c.String(maxLength: 200));
            AlterColumn("dbo.Engineers", "Eng_Name", c => c.String(maxLength: 200));
        }
    }
}
