using System;
using System.Linq;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // a. Start with a base of $50 / month
                decimal quote = 50.0m;

                // Calculate exact age
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth > DateTime.Now.AddYears(-age))
                {
                    age--;
                }

                // b, c, d. Age-based additions
                if (age <= 18)
                {
                    quote += 100m;
                }
                else if (age >= 19 && age <= 25)
                {
                    quote += 50m;
                }
                else
                {
                    quote += 25m;
                }

                // e, f. Car year additions
                if (insuree.CarYear < 2000)
                {
                    quote += 25m;
                }
                else if (insuree.CarYear > 2015)
                {
                    quote += 25m;
                }

                // g, h. Car Make and Model additions
                if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake.Trim().ToLower() == "porsche")
                {
                    quote += 25m;

                    if (!string.IsNullOrEmpty(insuree.CarModel) && insuree.CarModel.Trim().ToLower() == "911 carrera")
                    {
                        quote += 25m;
                    }
                }

                // i. Add $10 for every speeding ticket
                quote += (insuree.SpeedingTickets * 10m);

                // j. If the user has ever had a DUI, add 25% to the total
                if (insuree.DUI)
                {
                    quote *= 1.25m;
                }

                // k. If it's full coverage, add 50% to the total
                if (insuree.CoverageType)
                {
                    quote *= 1.50m;
                }

                insuree.Quote = quote;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(insuree);
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            var insurees = db.Insurees.ToList();
            return View(insurees);
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
