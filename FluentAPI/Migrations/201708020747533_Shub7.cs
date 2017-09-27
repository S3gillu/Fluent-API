namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub7 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "Self.Engineer_Table", newName: "Employee_Tab1");
            RenameTable(name: "Self.Project_Table", newName: "Project");
            MoveTable(name: "Self.Employee_Tab1", newSchema: "dbo");
            MoveTable(name: "Self.Project", newSchema: "dbo");
            CreateTable(
                "dbo.Employee_Tab2",
                c => new
                    {
                        Eng_Id = c.Int(nullable: false),
                        Number_Of_Projects = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Eng_Id)
                .ForeignKey("dbo.Employee_Tab1", t => t.Eng_Id)
                .Index(t => t.Eng_Id);
            
            DropColumn("dbo.Employee_Tab1", "Number_Of_Projects");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee_Tab1", "Number_Of_Projects", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employee_Tab2", "Eng_Id", "dbo.Employee_Tab1");
            DropIndex("dbo.Employee_Tab2", new[] { "Eng_Id" });
            DropTable("dbo.Employee_Tab2");
            MoveTable(name: "dbo.Project", newSchema: "Self");
            MoveTable(name: "dbo.Employee_Tab1", newSchema: "Self");
            RenameTable(name: "Self.Project", newName: "Project_Table");
            RenameTable(name: "Self.Employee_Tab1", newName: "Engineer_Table");
        }
    }
}
