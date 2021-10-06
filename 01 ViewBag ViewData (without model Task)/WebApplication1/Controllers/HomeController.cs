using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Viewbag()
        {
            ViewBag.Months = new List<string>()
            {
                "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };
            ViewBag.Name = "Mustafa";
            return View();
        }
        public ActionResult IndexViewdata()
        {
            ViewData["Name"] = "Mustafa";

            ViewData["Weeks"] = new List<string>()
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sataurday", "Sunday"
            };
            return View();
        }
    }
}