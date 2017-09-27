namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub5 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "DboNew.Engineer_Table", newSchema: "Self");
            MoveTable(name: "DboNew.Project_Table", newSchema: "Self");
        }
        
        public override void Down()
        {
            MoveTable(name: "Self.Project_Table", newSchema: "DboNew");
            MoveTable(name: "Self.Engineer_Table", newSchema: "DboNew");
        }
    }
}
