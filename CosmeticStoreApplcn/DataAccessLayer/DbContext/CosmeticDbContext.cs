using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticEntities;
using System.Data.Entity;

namespace DataAccessLayer.DbContext
{
   public class CosmeticDbContext:System.Data.Entity.DbContext
    {
        public  CosmeticDbContext():base("name=CosmeticStore")
            {

            }
        public virtual DbSet<CosmeticDetails> cosmeticDetails { get; set;}
        public virtual DbSet<Favourites> favourites { get; set; }
    }
}
