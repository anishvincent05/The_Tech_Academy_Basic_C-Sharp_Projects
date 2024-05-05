using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUO,SpeedingTicket,CoverageType")] Table table)
        {
            if (ModelState.IsValid)
            {
                table = Quotes(table);//Method for Calculating Quotes (Defined in bottom)
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUO,SpeedingTicket,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
        Table Quotes(Table tabl)//Method for Calculating Quotes
        {
            decimal quot = 50m;
            int ageTemp = DateTime.Now.Year - tabl.DateofBirth.Year;
            if (ageTemp <= 18)
            { quot += 100m; }
            if (ageTemp >= 19 && ageTemp <= 25)
            { quot += 50m; }
            if (ageTemp >= 26)
            { quot += 25m; }
            if (tabl.CarYear < 2000)
            { quot += 25m; }
            if (tabl.CarYear > 2015)
            { quot += 25m; }
            if (tabl.CarMake.ToLower() == "porsche")
            { 
                quot += 25m;
                if (tabl.CarModel.ToLower() == "911 carrera")
                { quot += 25m; }
            }
            quot += Convert.ToDecimal(tabl.SpeedingTicket) * 10;
            if (tabl.DUO)
            { quot += quot * .25m; }
            if (tabl.CoverageType)
            { quot += quot * .5m; }
            tabl.Quote = quot;
            return tabl;

        }
    }
}
