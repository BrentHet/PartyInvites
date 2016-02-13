using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PartyInvities.Models;

namespace PartyInvities.Controllers
{
    public class RentalPropertiesController : Controller
    {
        private RentalPropertyContext db = new RentalPropertyContext();

        // GET: RentalProperties
        public ActionResult Index()
        {
            return View(db.RentalProperties.ToList());
        }

        // GET: RentalProperties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentalProperty rentalProperty = db.RentalProperties.Find(id);
            if (rentalProperty == null)
            {
                return HttpNotFound();
            }
            return View(rentalProperty);
        }

        // GET: RentalProperties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentalProperties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] RentalProperty rentalProperty)
        {
            if (ModelState.IsValid)
            {
                db.RentalProperties.Add(rentalProperty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rentalProperty);
        }

        // GET: RentalProperties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentalProperty rentalProperty = db.RentalProperties.Find(id);
            if (rentalProperty == null)
            {
                return HttpNotFound();
            }
            return View(rentalProperty);
        }

        // POST: RentalProperties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] RentalProperty rentalProperty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentalProperty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rentalProperty);
        }

        // GET: RentalProperties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentalProperty rentalProperty = db.RentalProperties.Find(id);
            if (rentalProperty == null)
            {
                return HttpNotFound();
            }
            return View(rentalProperty);
        }

        // POST: RentalProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RentalProperty rentalProperty = db.RentalProperties.Find(id);
            db.RentalProperties.Remove(rentalProperty);
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
