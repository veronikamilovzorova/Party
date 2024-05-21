using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Party.Models
{
    public class GuestDbIntializer: CreateDatabaseIfNotExists<GuestContext> 
    {
        protected override void Seed(GuestContext db)
        {
            base.Seed(db);
        }
    }
}