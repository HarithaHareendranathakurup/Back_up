using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer.ServiceRepository;

namespace BusinessLayer.Business
{
    public class Business
    {
        Service sc = new Service();

        public void AddRoom(Room room)
        {
            sc.AllocateRooms(room);
            
        }
    }
}
