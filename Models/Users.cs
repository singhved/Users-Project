using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Users.Models
{
    [Table("Users")]
    public class Users
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Contact { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        public string Gender { get; set; }
        [Display(Name ="User Type")]
        public string Type { get; set; }
        public string Address { get; set; }
    }
}