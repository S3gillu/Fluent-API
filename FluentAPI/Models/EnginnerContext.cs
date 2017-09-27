using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class EnginnerContext : DbContext
    {
        public EnginnerContext() : base("name=Emp_Connect")
        {

        }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Project> Projects { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure Domain Classes  Here 
     
            modelBuilder.HasDefaultSchema("DboNew"); //only Schema 

            base.OnModelCreating(modelBuilder);



            //Only Table Name
            /* modelBuilder.Entity<Engineer>().ToTable("Engineer_Table");
             modelBuilder.Entity<Project>().ToTable("Project_Table");
             */


            //Schema with table name
            /* modelBuilder.Entity<Engineer>().ToTable("Engineer_Table","Self");
             modelBuilder.Entity<Project>().ToTable("Project_Table","Self");
             */


            //Entity Splitting
            /* modelBuilder.Entity<Engineer>().Map(e =>

             {
                 e.Properties(p => new { p.Eng_Id, p.Eng_Name, p.Deparment });
                 e.ToTable("Employee_Tab1");
             }).Map(e =>
             {
                 e.Properties(p => new  { p.Eng_Id, p.Number_Of_Projects });
                 e.ToTable("Employee_Tab2");
             });

             modelBuilder.Entity<Project>().ToTable("Project");
             */
            modelBuilder.Entity<Engineer>().Property(p => p.Deparment)
                .HasColumnName("Eng_Name")
                .HasColumnOrder(2)
                .IsRequired()
                .HasMaxLength(200);
            modelBuilder.Entity<Engineer>().Property(p => p.Number_Of_Projects)
             
               .HasColumnOrder(3)
               .IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Project_Name)
                .IsRequired()
                .HasColumnOrder(2)
                .HasMaxLength(200);
            modelBuilder.Entity<Project>().Property(p => p.Project_Head)
               .HasColumnOrder(3)
               .IsRequired()
               .HasMaxLength(200);


        }

     
    }
}