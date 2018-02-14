using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;
namespace MyMVCApplication.Controllers
{
    public class MyModelController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
        [HttpPost]
        public ActionResult MyModel_Create(MyModel model)
        {
            if (!ModelState.IsValid)
            {
                /* If model is invalid, as expected, return the same
                view and send the invalid model to update validation. */
                return View("form", model);
            }

            // Return a script that runs the parent's window close method.
            return Content("<script>window.parent.closeFormPopup()</script>");
        }
    }
}
