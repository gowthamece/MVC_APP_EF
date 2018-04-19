using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Index Page 
        {
            return View();
        }

        [Authorize]
        public ActionResult About() //About us PAge
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize(Roles ="Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}