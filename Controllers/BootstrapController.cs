using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMVC.Controllers
{
    public class BootstrapController : Controller
    {
        // GET: Bootscrap
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Collapse()
        {
            return PartialView("Collapse");
        }
        public ActionResult Alert()
        {
            return PartialView("Alert");
        }
    }
}