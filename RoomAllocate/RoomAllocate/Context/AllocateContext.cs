using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RoomAllocate.Models;

namespace RoomAllocate.Context
{
    public class AllocateContext : DbContext
    {
        public AllocateContext() : base("name=AllocateContext")
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<AllocateRooms> AllocateRooms { get; set; }
    }
}