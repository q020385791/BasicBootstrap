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
            return PartialView("Index");
        }
        public ActionResult Collapse()
        {
            return PartialView("Collapse");
        }
        public ActionResult Alert()
        {
            return PartialView("Alert");
        }
        public ActionResult Badges()
        {
            return PartialView("Badges");
        }
        public ActionResult Breadcrumb()
        {
            return PartialView("Breadcrumb");
        }

        public ActionResult Buttons()
        {
            return PartialView("Buttons");
        }
        



    }
}