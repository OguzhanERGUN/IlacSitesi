using IlacSitesi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IlacSitesi.Concreate
{
    public class Context: DbContext
    {
        public DbSet<Ilac> Ilacs { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<MonoklonalAntikors> MonoklonalAntikors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Indications> Indications { get; set; }


    }
}