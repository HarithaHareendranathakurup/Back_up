using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoomAllocations.Models
{
    public class CamContext:DbContext
    {
        public CamContext():base("name=CamContext")
        {

        }
        public DbSet<Mindss> Mindss { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<UserRoom> UserRooms { get; set; }
    }
}