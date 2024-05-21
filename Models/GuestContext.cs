using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Party.Models
{

    public class GuestContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Birthday> Birthday { get; set; }
    }
}