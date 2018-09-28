using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RoomAllocate.Context;
using RoomAllocate.Models;

namespace RoomAllocate.Controllers
{
    public class AllocateRoomsController : Controller
    {
        private AllocateContext db = new AllocateContext();

        // GET: AllocateRooms
        public ActionResult Index()
        {
            var allocateRooms = db.AllocateRooms.Include(a => a.Roomss).Include(a => a.Users);
            return View(allocateRooms.ToList());
        }

        // GET: AllocateRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllocateRooms allocateRooms = db.AllocateRooms.Find(id);
            if (allocateRooms == null)
            {
                return HttpNotFound();
            }
            return View(allocateRooms);
        }

        // GET: AllocateRooms/Create
        public ActionResult Create()
        {
           // var rooms = (from a in db.AllocateRooms select a.RNO).ToList();
            //var urooms=(from b in db.Rooms where !rooms.Contains(b.RNO) select b).ToList();
            var user = (from a in db.AllocateRooms select a.MNO).ToList();
            var uuser = (from b in db.Users where !user.Contains(b.MNO) select b).ToList();
            ViewBag.RNO = new SelectList(db.Rooms, "RNO", "RID");
            ViewBag.MNO = new SelectList(uuser, "MNO", "MID");
            return View();
        }

        // POST: AllocateRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SNO,MNO,RNO")] AllocateRooms allocateRooms)
        {
            //try
          //  {
                if (ModelState.IsValid)
                {
                    var s = allocateRooms.RNO;
                    var s1=(from b in db.AllocateRooms where s.Equals(b.RNO) select b).ToList();
                    var c = s1.Count();
                    if (c < 4)
                    {
                        db.AllocateRooms.Add(allocateRooms);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                    TempData["msg"] = "<script>alert('Select another room');</script>";
                    //ViewBag.message = "Please select another room";
                        return RedirectToAction("Create"); ;

                    }
                }
            //}
            /*catch(Exception e)
            {
                //ViewBag.Message = "MID/RID is already added";
                //return View(allocateRooms);
                return View("Exception");
            }*/

            //ViewBag.RNO = new SelectList(db.Rooms, "RNO", "RID", allocateRooms.RNO);
            //ViewBag.MNO = new SelectList(db.Users, "MNO", "MID", allocateRooms.MNO);
            return View(allocateRooms);
        }

        // GET: AllocateRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllocateRooms allocateRooms = db.AllocateRooms.Find(id);
            if (allocateRooms == null)
            {
                return HttpNotFound();
            }
            ViewBag.RNO = new SelectList(db.Rooms, "RNO", "RID", allocateRooms.RNO);
            ViewBag.MNO = new SelectList(db.Users, "MNO", "MID", allocateRooms.MNO);
            return View(allocateRooms);
        }

        // POST: AllocateRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SNO,MNO,RNO")] AllocateRooms allocateRooms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allocateRooms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RNO = new SelectList(db.Rooms, "RNO", "RID", allocateRooms.RNO);
            ViewBag.MNO = new SelectList(db.Users, "MNO", "MID", allocateRooms.MNO);
            return View(allocateRooms);
        }

        // GET: AllocateRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllocateRooms allocateRooms = db.AllocateRooms.Find(id);
            if (allocateRooms == null)
            {
                return HttpNotFound();
            }
            return View(allocateRooms);
        }

        // POST: AllocateRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AllocateRooms allocateRooms = db.AllocateRooms.Find(id);
            db.AllocateRooms.Remove(allocateRooms);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
