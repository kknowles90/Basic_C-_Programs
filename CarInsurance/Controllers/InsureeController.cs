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
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        public GetQuote(int Id, string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, bool DUI, int SpeedingTickets, bool CoverageType, decimal Quote)
        {


            Quote = 50;
            int age = DateTime.Now.Subtract(DateOfBirth).Days;
            age = age / 365;//converts DateOfBirth to age in years.

            //Age of driver
            if (age < 18)
            {
                Quote += 50;
            }
            else if (age < 25)
            {
                Quote += 25;
            }
            else
            {
                Quote += 50;
            }

            //CarYear input
            if (CarYear < 2000)
            {
                Quote += 25;
            }
            if (CarYear > 2015)
            {
                Quote += 25;
            }

            //carmake and model input
            if (CarMake == "Porsche")
            {
                Quote += 25;
            }

            if (CarMake == "Porsche" && CarModel == "911 Carrera")
            {
                Quote += 25;
            }

            //input for speeding tickets
            int SpeedingTicketValue = SpeedingTickets * 10;
            Quote += SpeedingTicketValue;

            //input for DUI
            if (DUI == true)
            {
                Quote += 25;
            }

            //coverage input
            if (CoverageType == true)
            {
                Quote += Quote / 2;
            }

            return Insuree.Quote;
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var allinsurees = new List<Insuree>();
                foreach (var var1 in insurees)
                {
                    Insuree insuree = new Insuree();
                    insuree.FirstName = var1.FirstName;
                    insuree.LastName = var1.LastName;
                    insuree.EmailAddress = var1.EmailAddress;
                    GetQuote(insuree.Id, insuree.FirstName, insuree.LastName, insuree.EmailAddress, insuree.DateOfBirth, insuree.CarYear, insuree.CarMake, insuree.CarModel, insuree.DUI, insuree.SpeedingTickets, insuree.CoverageType, insuree.Quote);
                    //insuree.Id = var1.Id;
                    //insuree.DateOfBirth = var1.DateOfBirth;
                    //insuree.CarYear = var1.CarYear;
                    //insuree.CarMake = var1.CarMake;
                    //insuree.CarModel = var1.CarModel;
                    //insuree.DUI = var1.DUI;
                    //insuree.SpeedingTickets = var1.SpeedingTickets;
                    //insuree.CoverageType = var1.CoverageType;
                    allinsurees.Add(insuree);
                   
                }
                return View(insurees);
            }
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
