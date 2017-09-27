namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub15 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Engineers", newSchema: "DboNew");
            MoveTable(name: "dbo.Projects", newSchema: "DboNew");
        }
        
        public override void Down()
        {
            MoveTable(name: "DboNew.Projects", newSchema: "dbo");
            MoveTable(name: "DboNew.Engineers", newSchema: "dbo");
        }
    }
}
