using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CosmeticEntities;
using BusinessLayer;
using DataAccessLayer.DbContext;
using System.Threading.Tasks;

namespace CosmeticStoreApplcn.Controllers
{
    public class CosmeticDetailsController : Controller
    {
        private CosmeticDbContext db = new CosmeticDbContext();

        CosmeticManager cm = new CosmeticManager();
        // GET: CosmeticDetails
        public ActionResult Index()
        {
            return View(db.cosmeticDetails.ToList());
        }

        // GET: CosmeticDetails/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CosmeticDetails cosmeticDetails = db.cosmeticDetails.Find(id);
            if (cosmeticDetails == null)
            {
                return HttpNotFound();
            }
            return View(cosmeticDetails);
        }

        // GET: CosmeticDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CosmeticDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CosmeticTitle,Company,Category,Quantity,price")] CosmeticDetails cosmeticDetails)
        {
            if (ModelState.IsValid)
            {
                db.cosmeticDetails.Add(cosmeticDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cosmeticDetails);
        }

        // GET: CosmeticDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CosmeticDetails cosmeticDetails = db.cosmeticDetails.Find(id);
            if (cosmeticDetails == null)
            {
                return HttpNotFound();
            }
            return View(cosmeticDetails);
        }

        // POST: CosmeticDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CosmeticTitle,Company,Category,Quantity,price")] CosmeticDetails cosmeticDetails)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(cosmeticDetails).State = EntityState.Modified;
                //db.SaveChanges();
                cm.UpdateCosmeticDetail(cosmeticDetails);
                return RedirectToAction("Index");
            }
            return View(cosmeticDetails);
        }

        // GET: CosmeticDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CosmeticDetails cosmeticDetails = db.cosmeticDetails.Find(id);
            if (cosmeticDetails == null)
            {
                return HttpNotFound();
            }
            return View(cosmeticDetails);
        }

        // POST: CosmeticDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            //CosmeticDetails cosmeticDetails = db.cosmeticDetails.Find(id);
            //db.cosmeticDetails.Remove(cosmeticDetails);
            //db.SaveChanges();
            cm.DeleteCosmeticDetails(id);
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
