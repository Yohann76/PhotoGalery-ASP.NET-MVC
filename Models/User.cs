using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhotoGalery.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
    }

    public class BddContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}