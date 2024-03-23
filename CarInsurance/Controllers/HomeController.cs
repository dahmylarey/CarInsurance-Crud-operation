using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var insuree = new Insuree();
                    insuree.FirstName = firstName;
                    insuree.LastName = lastName;
                    insuree.EmailAddress = emailAddress;
                    insuree.Quote = insuree.Quote;

                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                }
                return View("Success");
            }
        }
    }
}