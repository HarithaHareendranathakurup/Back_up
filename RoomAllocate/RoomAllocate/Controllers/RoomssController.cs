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
    public class RoomssController : Controller
    {
        private AllocateContext db = new AllocateContext();

        // GET: Roomss
        public ActionResult Index()
        {
            return View(db.Rooms.ToList());
        }

        // GET: Roomss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rooms roomss = db.Rooms.Find(id);
            if (roomss == null)
            {
                return HttpNotFound();
            }
            return View(roomss);
        }

        // GET: Roomss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roomss/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RNO,RID,BlockName,FloorName")] Rooms roomss)
        {
            if (ModelState.IsValid)
            {
                db.Rooms.Add(roomss);
                db.SaveChanges();
                // return RedirectToAction("Index");
                return View("Create1");
            }

            return View(roomss);
        }

        // GET: Roomss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rooms roomss = db.Rooms.Find(id);
            if (roomss == null)
            {
                return HttpNotFound();
            }
            return View(roomss);
        }

        // POST: Roomss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RNO,RID,BlockName,FloorName")] Rooms roomss)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roomss);
        }

        // GET: Roomss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rooms roomss = db.Rooms.Find(id);
            if (roomss == null)
            {
                return HttpNotFound();
            }
            return View(roomss);
        }

        // POST: Roomss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rooms roomss = db.Rooms.Find(id);
            db.Rooms.Remove(roomss);
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
