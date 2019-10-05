//PURPOSE:    Build an application for generating quotes for car insurance
//AUTHOR:     Robert Manez

using CarInsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //passing in user input values
        public ActionResult Estimate(string firstName, string lastName, string email, DateTime birthday, int carYear,
                                     string carMake, string carModel, string dui, int speedingTickets, string coverage)
        {
            //accessing database
            using (CarInsuranceEntities1 db = new CarInsuranceEntities1())
            {
                //instantiating a class object and assigning it properties based on user input
                var customer = new Customer();
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.Email = email;
                customer.Birthday = birthday;
                customer.CarYear = carYear;
                customer.CarMake = carMake;
                customer.CarModel = carModel;
                customer.DUI = dui;
                customer.SpeedingTickets = speedingTickets;
                customer.Coverage = coverage;

                //adding and saving new class object to database
                db.Customers.Add(customer);
                db.SaveChanges();
            }

            return View("Estimate");
        }
    }
}