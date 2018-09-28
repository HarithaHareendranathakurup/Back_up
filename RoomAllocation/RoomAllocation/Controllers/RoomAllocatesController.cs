using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RoomAllocation.Models;

namespace RoomAllocation.Controllers
{
    public class RoomAllocatesController : ApiController
    {
        private AllocationEntities db = new AllocationEntities();


        // POST: api/RoomAllocates
        [ResponseType(typeof(RoomAllocate))]
        public IHttpActionResult PostRoomAllocate(RoomAllocate roomAllocate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RoomAllocates.Add(roomAllocate);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RoomAllocateExists(roomAllocate.RId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = roomAllocate.RId }, roomAllocate);
        }

       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RoomAllocateExists(int id)
        {
            return db.RoomAllocates.Count(e => e.RId == id) > 0;
        }
    }
}