using MVC_ElevenPartAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ElevenPartAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\roman\OneDrive\Documents\GitHub\C-Sharp-Projects\MVC_ElevenPartAssignment\log.txt", text);

            //Random rnd = new Random(10);
            //var num = rnd.Next();
            ////ViewBag.RandomNumber = num;

            //if (num > 20000)
            //{
            //    return View("About");
            //}
            //return RedirectToAction("Contact");

            // Creates List of strings
            //List<string> names = new List<string>
            //{
            //    "Broman",
            //    "Kristie",
            //    "Bruce"
            //};

            //// Passes number
            //int number = 5;

            User user = new User();
            user.Id = 1;
            user.FirstName = "Brandon";
            user.LastName = "Roman";
            user.Age = 26;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //// Returns exception error
            //throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            //ViewBag.Message = "Your contact page.";
            ViewBag.Message = id; 
            return View();
        }
    }
}