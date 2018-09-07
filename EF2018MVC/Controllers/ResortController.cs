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
    public class ResortController : Controller
    {
        private BreakAwayContext db = new BreakAwayContext();

        // GET: Resort
        public ActionResult Index()
        {
            var lodgings = db.Resort.Include(r => r.Destination);
            return View(lodgings.ToList());
        }

        // GET: Resort/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resort resort = db.Resort.Find(id);
            if (resort == null)
            {
                return HttpNotFound();
            }
            return View(resort);
        }

        // GET: Resort/Create
        public ActionResult Create()
        {
            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name");
            return View();
        }

        // POST: Resort/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LodgingId,Name,Owner,IsResort,MilesFromNearestAirport,DestinationId,Entertainment,Activities")] Resort resort)
        {
            if (ModelState.IsValid)
            {
                db.Lodgings.Add(resort);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name", resort.DestinationId);
            return View(resort);
        }

        // GET: Resort/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resort resort = db.Resort.Find(id);
            if (resort == null)
            {
                return HttpNotFound();
            }
            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name", resort.DestinationId);
            return View(resort);
        }

        // POST: Resort/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LodgingId,Name,Owner,IsResort,MilesFromNearestAirport,DestinationId,Entertainment,Activities")] Resort resort)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resort).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DestinationId = new SelectList(db.Destinations, "DestinationId", "Name", resort.DestinationId);
            return View(resort);
        }

        // GET: Resort/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resort resort = db.Resort.Find(id);
            if (resort == null)
            {
                return HttpNotFound();
            }
            return View(resort);
        }

        // POST: Resort/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Resort resort = db.Resort.Find(id);
            db.Lodgings.Remove(resort);
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
