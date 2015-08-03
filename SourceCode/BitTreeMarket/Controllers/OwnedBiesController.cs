using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitTreeMarket.Data;
using BitTreeMarket.Model;

namespace BitTreeMarket.Controllers
{
    public class OwnedBiesController : Controller
    {
        private BitTreeMarketDbContext db = new BitTreeMarketDbContext();

        // GET: OwnedBies
        public ActionResult Index()
        {
            var ownedBies = db.OwnedBies.Include(o => o.Corporation);
            return View(ownedBies.ToList());
        }

        // GET: OwnedBies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnedBy ownedBy = db.OwnedBies.Find(id);
            if (ownedBy == null)
            {
                return HttpNotFound();
            }
            return View(ownedBy);
        }

        // GET: OwnedBies/Create
        public ActionResult Create()
        {
            ViewBag.CorporationId = new SelectList(db.Corporations, "CorporationId", "Name");
            return View();
        }

        // POST: OwnedBies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OwnedById,CorporationId,MembersId")] OwnedBy ownedBy)
        {
            if (ModelState.IsValid)
            {
                db.OwnedBies.Add(ownedBy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CorporationId = new SelectList(db.Corporations, "CorporationId", "Name", ownedBy.CorporationId);
            return View(ownedBy);
        }

        // GET: OwnedBies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnedBy ownedBy = db.OwnedBies.Find(id);
            if (ownedBy == null)
            {
                return HttpNotFound();
            }
            ViewBag.CorporationId = new SelectList(db.Corporations, "CorporationId", "Name", ownedBy.CorporationId);
            return View(ownedBy);
        }

        // POST: OwnedBies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OwnedById,CorporationId,MembersId")] OwnedBy ownedBy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ownedBy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CorporationId = new SelectList(db.Corporations, "CorporationId", "Name", ownedBy.CorporationId);
            return View(ownedBy);
        }

        // GET: OwnedBies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnedBy ownedBy = db.OwnedBies.Find(id);
            if (ownedBy == null)
            {
                return HttpNotFound();
            }
            return View(ownedBy);
        }

        // POST: OwnedBies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OwnedBy ownedBy = db.OwnedBies.Find(id);
            db.OwnedBies.Remove(ownedBy);
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
