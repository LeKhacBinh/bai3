using bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Book> listBook = HttpContext.Application["listBook"] as List<Book>;

            return View(listBook);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}