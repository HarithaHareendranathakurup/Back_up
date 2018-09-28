using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CampusMinds.Models
{
    public class MindsContext:DbContext
    {
        public MindsContext():base("name=MindsContext")
        {

        }
        public DbSet<Minds> Minds { get; set; }
        public DbSet<Tracks> Tracks { get; set; }

    }
}