using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.ServiceRepository
{
    public class Service
    {
        public Context.RoomDBContext dbContext;

        public Service()
        {
            dbContext = new Context.RoomDBContext();
        }
        public void AllocateRooms(Room room)
        {
            dbContext.Rooms.Add(room);
            dbContext.SaveChanges();
        }
    }
}
