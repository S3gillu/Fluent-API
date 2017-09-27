using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models
{
    public class Engineer
    {

        [Key]
        public int Eng_Id { get; set; }
        public string Eng_Name { get; set; }
        public string Deparment { get; set; }
        public int Number_Of_Projects { get; set; }
        public Project Project { get; set; }
    }
}