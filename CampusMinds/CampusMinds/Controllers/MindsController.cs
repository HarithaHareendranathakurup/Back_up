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
    public class MindsController : Controller
    {
        private MindsContext db = new MindsContext();

        // GET: Minds
        public ActionResult Index()
        {
            var minds = db.Minds.Include(m => m.Tracks);
            return View(minds.ToList());
        }

        // GET: Minds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Minds minds = db.Minds.Find(id);
            if (minds == null)
            {
                return HttpNotFound();
            }
            return View(minds);
        }

        // GET: Minds/Create
        public ActionResult Create()
        {
            ViewBag.TrackId = new SelectList(db.Tracks, "Trackid", "TrackName");
            return View();
        }

        // POST: Minds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MID,Name,Gender,ContactId,TrackId")] Minds minds)
        {
            if (ModelState.IsValid)
            {
                db.Minds.Add(minds);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TrackId = new SelectList(db.Tracks, "Trackid", "TrackName", minds.TrackId);
            return View(minds);
        }

        // GET: Minds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Minds minds = db.Minds.Find(id);
            if (minds == null)
            {
                return HttpNotFound();
            }
            ViewBag.TrackId = new SelectList(db.Tracks, "Trackid", "TrackName", minds.TrackId);
            return View(minds);
        }

        // POST: Minds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MID,Name,Gender,ContactId,TrackId")] Minds minds)
        {
            if (ModelState.IsValid)
            {
                db.Entry(minds).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TrackId = new SelectList(db.Tracks, "Trackid", "TrackName", minds.TrackId);
            return View(minds);
        }

        // GET: Minds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Minds minds = db.Minds.Find(id);
            if (minds == null)
            {
                return HttpNotFound();
            }
            return View(minds);
        }

        // POST: Minds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Minds minds = db.Minds.Find(id);
            db.Minds.Remove(minds);
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
