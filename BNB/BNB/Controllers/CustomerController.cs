using BNB.DAL;
using BNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BNB.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InsertDB(string firstName, string lastName, string phone,
            string email, PreferredContactMethod? contactMethod, DateTime checkIn, 
            DateTime checkOut, int BnbID)
        {
            using (BedAndBreakfastContext db = new BedAndBreakfastContext())
            {
                var customer = new Customer();
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.Phone = phone;
                customer.Email = email;
                customer.ContactMethod = contactMethod;
                customer.CheckIn = checkIn;
                customer.CheckOut = checkOut;
                customer.BnbID = BnbID;

                db.Customers.Add(customer);
                db.SaveChanges();

                return View("Success");
            }
        }
    }
}