using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testMVC.ViewModels;

namespace testMVC.Controllers
{
    public class Test1Controller : Controller
    {
        // GET: Test1
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult CheckIP()
        {
            string ip = Request.UserHostAddress;
            CheckIPViewModel model = new CheckIPViewModel();
            model.IP = ip;
            return PartialView("CheckIP", model);
        }

        public ActionResult CheckTime()
        {
            string Time = DateTime.Now.ToString();
            CheckTimeViewModel model = new CheckTimeViewModel();
            model.Time = Time;
            return PartialView("CheckTime", model);
        }
    }
}