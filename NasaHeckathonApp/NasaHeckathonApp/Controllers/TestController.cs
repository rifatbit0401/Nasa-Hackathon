using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        [HttpGet]
        public ActionResult Index()
        {
            string str = "hello";
            return Json(str,JsonRequestBehavior.AllowGet);
        }

    }
}
