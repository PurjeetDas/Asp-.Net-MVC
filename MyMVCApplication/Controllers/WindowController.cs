using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class WindowController : Controller
    {
        
        public ActionResult Api()
        {
            return View();
        }

        public ActionResult ApiContent()
        {
            return View("form");
        }
    }
}
