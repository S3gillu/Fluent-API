namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub8 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employee_Tab1", newName: "Engineers");
            RenameTable(name: "dbo.Project", newName: "Projects");
            DropForeignKey("dbo.Employee_Tab2", "Eng_Id", "dbo.Employee_Tab1");
            DropIndex("dbo.Employee_Tab2", new[] { "Eng_Id" });
            RenameColumn(table: "dbo.Engineers", name: "Eng_Name", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Engineers", name: "Deparment", newName: "Eng_Name");
            RenameColumn(table: "dbo.Engineers", name: "__mig_tmp__0", newName: "Eng_Name1");
            AddColumn("dbo.Engineers", "Number_Of_Projects", c => c.Int(nullable: false));
            AlterColumn("dbo.Engineers", "Eng_Name", c => c.String(maxLength: 200));
            AlterColumn("dbo.Engineers", "Eng_Name", c => c.String(maxLength: 200));
            DropTable("dbo.Employee_Tab2");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Employee_Tab2",
                c => new
                    {
                        Eng_Id = c.Int(nullable: false),
                        Number_Of_Projects = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Eng_Id);
            
            AlterColumn("dbo.Engineers", "Eng_Name", c => c.String());
            AlterColumn("dbo.Engineers", "Eng_Name", c => c.String());
            DropColumn("dbo.Engineers", "Number_Of_Projects");
            RenameColumn(table: "dbo.Engineers", name: "Eng_Name1", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Engineers", name: "Eng_Name", newName: "Deparment");
            RenameColumn(table: "dbo.Engineers", name: "__mig_tmp__0", newName: "Eng_Name");
            CreateIndex("dbo.Employee_Tab2", "Eng_Id");
            AddForeignKey("dbo.Employee_Tab2", "Eng_Id", "dbo.Employee_Tab1", "Eng_Id");
            RenameTable(name: "dbo.Projects", newName: "Project");
            RenameTable(name: "dbo.Engineers", newName: "Employee_Tab1");
        }
    }
}
