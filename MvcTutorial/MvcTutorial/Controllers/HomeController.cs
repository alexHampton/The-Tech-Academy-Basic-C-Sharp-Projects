using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\alext\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Logs\Log3.txt", text);

            //List<string> names = new List<string>
            //{
            //    "Alex",
            //    "Geoff",
            //    "Rustin"
            //};

            //int number = 5;
            User user = new User();
            user.Id = 1;
            user.FirstName = "Alex";
            user.LastName = "Hampton";
            user.Age = 29;
                       
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}