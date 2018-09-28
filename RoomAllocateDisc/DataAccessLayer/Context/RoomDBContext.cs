using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Entities;
//using RoomAllocate.Models;

namespace DataAccessLayer.Context
{
    public class RoomDBContext:DbContext
    {
        public RoomDBContext():base("name=RoomContext")
            {
            }
        public DbSet<Room> Rooms { get; set; }
    }
}
