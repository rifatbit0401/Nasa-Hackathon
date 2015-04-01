using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        [AllowAnonymous]
        public ActionResult Login()
        {
            String logIn = "logged in";
            return Json(logIn,JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public void Logout()
        {
            
        }

        

    }
}
