using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF2018MVC.Models;

namespace EF2018MVC.Controllers
{
    public class LodgingController : Controller
    {
        private BreakAwayContext db = new BreakAwayContext();

        // GET: Lodging
        public ActionResult Index()
        {
            var lodgings = db.Lodgings.Include(l => l.Destination);
            return View(lodgings.ToList());
        }

        // GET: Lodging/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lodging lodging = db.Lodgings.Find(id);
            if (lodging == null)
            {
                return HttpNotFound();
            }
            return View(lodging);
        }

        // GET: Lodging/Create
        public ActionResult Create()
        {
            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name");
            return View();
        }

        // POST: Lodging/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LodgingId,Name,Owner,IsResort,MilesFromNearestAirport,DestinationId")] Lodging lodging)
        {
            if (ModelState.IsValid)
            {
                db.Lodgings.Add(lodging);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name", lodging.DestinationId);
            return View(lodging);
        }

        // GET: Lodging/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lodging lodging = db.Lodgings.Find(id);
            if (lodging == null)
            {
                return HttpNotFound();
            }
            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name", lodging.DestinationId);
            return View(lodging);
        }

        // POST: Lodging/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LodgingId,Name,Owner,IsResort,MilesFromNearestAirport,DestinationId")] Lodging lodging)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lodging).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name", lodging.DestinationId);
            return View(lodging);
        }

        // GET: Lodging/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lodging lodging = db.Lodgings.Find(id);
            if (lodging == null)
            {
                return HttpNotFound();
            }
            return View(lodging);
        }

        // POST: Lodging/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lodging lodging = db.Lodgings.Find(id);
            db.Lodgings.Remove(lodging);
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
