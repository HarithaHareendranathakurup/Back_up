using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampusMinds.Models;

namespace CampusMinds.Controllers
{
    public class TracksController : Controller
    {
        private MindsContext db = new MindsContext();

        // GET: Tracks
        public ActionResult Index()
        {
            return View(db.Tracks.ToList());
        }

        // GET: Tracks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tracks tracks = db.Tracks.Find(id);
            if (tracks == null)
            {
                return HttpNotFound();
            }
            return View(tracks);
        }

        // GET: Tracks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tracks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Trackid,TrackName,RoomNo,LeadName")] Tracks tracks)
        {
            if (ModelState.IsValid)
            {
                db.Tracks.Add(tracks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tracks);
        }

        // GET: Tracks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tracks tracks = db.Tracks.Find(id);
            if (tracks == null)
            {
                return HttpNotFound();
            }
            return View(tracks);
        }

        // POST: Tracks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Trackid,TrackName,RoomNo,LeadName")] Tracks tracks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tracks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tracks);
        }

        // GET: Tracks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tracks tracks = db.Tracks.Find(id);
            if (tracks == null)
            {
                return HttpNotFound();
            }
            return View(tracks);
        }

        // POST: Tracks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tracks tracks = db.Tracks.Find(id);
            db.Tracks.Remove(tracks);
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
