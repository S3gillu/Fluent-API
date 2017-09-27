using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models
{
    public class Project
    {
        [Key]
        public int Project_Id { get; set; }
        public string Project_Name { get; set; }
        public string Project_Head { get; set; }
        public DateTime DeadLIne { get; set; }
        public ICollection<Engineer> Engineers { get; set; }


    }
}