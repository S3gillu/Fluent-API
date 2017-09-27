namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shub : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Engineers",
                c => new
                    {
                        Eng_Id = c.Int(nullable: false, identity: true),
                        Eng_Name = c.String(),
                        Deparment = c.String(),
                        Number_Of_Projects = c.Int(nullable: false),
                        Project_Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Eng_Id)
                .ForeignKey("dbo.Projects", t => t.Project_Project_Id)
                .Index(t => t.Project_Project_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Project_Id = c.Int(nullable: false, identity: true),
                        Project_Name = c.String(),
                        Project_Head = c.String(),
                        DeadLIne = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Project_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Engineers", "Project_Project_Id", "dbo.Projects");
            DropIndex("dbo.Engineers", new[] { "Project_Project_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.Engineers");
        }
    }
}
