using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

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

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth," +
                                                    "CarYear,CarMake,CarModel,DUI,SpeedingTickets," +
                                                    "CoverageType,Quote")] Insuree insuree)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<InsureeVm>();
                var insureeVm = new InsureeVm();
                insureeVm.Id = insuree.Id;
                insureeVm.FirstName = insuree.FirstName;
                insureeVm.LastName = insuree.LastName;
                insureeVm.EmailAddress = insuree.EmailAddress;
                insureeVm.DateOfBirth = insuree.DateOfBirth;
                insureeVm.CarYear = insuree.CarYear;
                insureeVm.CarMake = insuree.CarMake;
                insureeVm.CarModel = insuree.CarModel;
                insureeVm.DUI = insuree.DUI;
                insureeVm.SpeedingTickets = insuree.SpeedingTickets;
                insureeVm.CoverageType = insuree.CoverageType;
                insureeVm.Quote = insuree.Quote;

                int baseQuote = 50;
                int userAge = (int)((DateTime.Now - insuree.DateOfBirth).TotalDays / 365);
                if (userAge <= 18)
                {
                    baseQuote += 100;
                }
                else if (userAge > 19 && userAge <= 25)
                {
                    baseQuote += 50;
                }
                else if (userAge >= 26)
                {
                    baseQuote += 25;
                }
                int quoteAfterAge = baseQuote;

                // Calculating quote based on Car Year
                int carYear = insuree.CarYear;
                if (carYear < 2000 || carYear > 2015)
                {
                    quoteAfterAge += 25;
                }
                int quoteAgeYear = quoteAfterAge;

                // Calculates quote based off Make as Porsche
                var carMake = insuree.CarMake;
                var carModel = insuree.CarModel;
                if (carMake == "Porsche")
                {
                    quoteAgeYear += 25;
                }
                else if (carMake == "Porsche" && carModel == "911 Carrera")
                {
                    quoteAgeYear += 50;
                }
                int quoteAgeCar = quoteAgeYear;

                // Calculates quote based off previous quote number and number of speeding tickets
                var ticketNum = insuree.SpeedingTickets;
                var ticketCost = ticketNum * 10;
                int updatedQuote = quoteAgeCar + ticketCost;

                // Calculates updated Quote adding 25% to total if user has had DUI
                var quoteWithDUI = updatedQuote * 1.25;
                var updatedQuote2 = quoteWithDUI;

                if (!insuree.DUI)
                {
                    updatedQuote2 = quoteWithDUI;
                }
                else
                {
                    updatedQuote2 = updatedQuote;
                }
                var updatedQuote3 = updatedQuote2;

                // Calculates updated quote if full coverage is marked, then add 50% to total
                var userCov = updatedQuote3 * 1.5;
                var updatedQuote4 = userCov;

                if (!insuree.CoverageType)
                {
                    updatedQuote4 = userCov;
                }
                else
                {
                    updatedQuote4 = updatedQuote3;
                }
                var total = updatedQuote4;
                insuree.Quote = Convert.ToDecimal(total);
                insureeVm.Quote = insuree.Quote;


                insureeVms.Add(insureeVm);
            }

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                int baseQuote = 50;
                var insurees = db.Insurees;
                var adminVms = new List<AdminVm>();
                foreach (var insuree in insurees)
                {
                    var adminVm = new AdminVm();
                    adminVm.FirstName = insuree.FirstName;
                    adminVm.LastName = insuree.LastName;
                    adminVm.EmailAddress = insuree.EmailAddress;

                    int userAge = (int)((DateTime.Now - insuree.DateOfBirth).TotalDays / 365);
                    if (userAge <= 18)
                    {
                        baseQuote += 100;
                    }
                    else if (userAge > 19 && userAge <= 25)
                    {
                        baseQuote += 50;
                    }
                    else if (userAge >= 26)
                    {
                        baseQuote += 25;
                    }
                    int quoteAfterAge = baseQuote;

                    // Calculating quote based on Car Year
                    int carYear = insuree.CarYear;
                    if (carYear < 2000 || carYear > 2015)
                    {
                        quoteAfterAge += 25;
                    }
                    int quoteAgeYear = quoteAfterAge;

                    // Calculates quote based off Make as Porsche
                    var carMake = insuree.CarMake;
                    var carModel = insuree.CarModel;
                    if (carMake == "Porsche")
                    {
                        quoteAgeYear += 25;
                    }
                    else if (carMake == "Porsche" && carModel == "911 Carrera")
                    {
                        quoteAgeYear += 50;
                    }
                    int quoteAgeCar = quoteAgeYear;

                    // Calculates quote based off previous quote number and number of speeding tickets
                    var ticketNum = insuree.SpeedingTickets;
                    var ticketCost = ticketNum * 10;
                    int updatedQuote = quoteAgeCar + ticketCost;

                    // Calculates updated Quote adding 25% to total if user has had DUI
                    var quoteWithDUI = updatedQuote * 1.25;
                    var updatedQuote2 = quoteWithDUI;

                    if (!insuree.DUI)
                    {
                        updatedQuote2 = quoteWithDUI;
                    }
                    else
                    {
                        updatedQuote2 = updatedQuote;
                    }
                    var updatedQuote3 = updatedQuote2;

                    // Calculates updated quote if full coverage is marked, then add 50% to total
                    var userCov = updatedQuote3 * 1.5;
                    var updatedQuote4 = userCov;

                    if (!insuree.CoverageType)
                    {
                        updatedQuote4 = userCov;
                    }
                    else
                    {
                        updatedQuote4 = updatedQuote3;
                    }
                    var total = updatedQuote4;
                    insuree.Quote = Convert.ToDecimal(total);
                    adminVm.Quote = insuree.Quote;
                    adminVms.Add(adminVm);
                }
                return View(adminVms);
            }
  
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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
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
