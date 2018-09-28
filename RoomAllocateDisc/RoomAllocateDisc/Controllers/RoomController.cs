using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Business;
using Entities;

namespace RoomAllocateDisc.Controllers
{
    [CustomExcceptionFilter]
    public class RoomController : ApiController
    {
        Business ob = new Business();
        [HttpPost]
        [Route("api/RoomController/Post")]
        public Room PostRooms(Room room)
        {
            try
            {
                  ob.AddRoom(room);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentNullException("Details cannot bee null");

            }
            return room;
        }
        [Route("api/RoomController/run")]
        public string run()
        {
            return "Welcome";
        }
    }
}
