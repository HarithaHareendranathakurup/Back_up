using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RoomAllocations.Models;

namespace RoomAllocations.Controllers
{
    public class MindssController : Controller
    {
        private CamContext db = new CamContext();

        // GET: Mindss
        public ActionResult Index()
        {
            return View(db.Mindss.ToList());
        }

        // GET: Mindss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mindss mindss = db.Mindss.Find(id);
            if (mindss == null)
            {
                return HttpNotFound();
            }
            return View(mindss);
        }

        // GET: Mindss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mindss/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MID,MindName,TrackName")] Mindss mindss)
        {
            if (ModelState.IsValid)
            {
                db.Mindss.Add(mindss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mindss);
        }

        // GET: Mindss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mindss mindss = db.Mindss.Find(id);
            if (mindss == null)
            {
                return HttpNotFound();
            }
            return View(mindss);
        }

        // POST: Mindss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MID,MindName,TrackName")] Mindss mindss)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mindss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mindss);
        }

        // GET: Mindss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mindss mindss = db.Mindss.Find(id);
            if (mindss == null)
            {
                return HttpNotFound();
            }
            return View(mindss);
        }

        // POST: Mindss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mindss mindss = db.Mindss.Find(id);
            db.Mindss.Remove(mindss);
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
