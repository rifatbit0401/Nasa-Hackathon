using System.Web.Security;
using NasaHeckathonApp.Service;
using NasaHeckathonApp.View_Models;
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
        private AccountService _accountService = new AccountService();
        
        [AllowAnonymous]
        [HttpPost]
        public ActionResult SignUp(SignUpInfo signUpInfo)
        {
            bool validUser = _accountService.SignUp(signUpInfo);
            if(!validUser)
            {
                Response.StatusCode = 400;
                var error = "error";
                return Json(error, JsonRequestBehavior.AllowGet);
            }
            FormsAuthentication.SetAuthCookie(signUpInfo.UserName, true);
            return Json(_accountService.GetUser(signUpInfo.UserName));
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginInfo loginInfo)
        {
            if (!_accountService.IsAuthenticated(loginInfo))
                return Json(null, JsonRequestBehavior.AllowGet);

            FormsAuthentication.SetAuthCookie(loginInfo.UserName, true);
            return Json(_accountService.GetUser(loginInfo.UserName));
        }



        [AllowAnonymous]
        public void Logout()
        {
            FormsAuthentication.SignOut();

        }



    }
}
