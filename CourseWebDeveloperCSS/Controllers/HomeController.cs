using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseWebDeveloperCSS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aula03()
        {
            return View("Aula03");
        }

        public ActionResult Aula04()
        {
            return View("Aula04");
        }
    }
}