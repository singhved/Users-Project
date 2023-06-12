using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Users.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Users> User { get; set; }
        
        
    }
}