namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "DboNew.Engineers", newName: "Engineer_Table");
            RenameTable(name: "DboNew.Projects", newName: "Project_Table");
        }
        
        public override void Down()
        {
            RenameTable(name: "DboNew.Project_Table", newName: "Projects");
            RenameTable(name: "DboNew.Engineer_Table", newName: "Engineers");
        }
    }
}
