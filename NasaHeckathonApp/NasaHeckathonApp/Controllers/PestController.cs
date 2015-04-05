using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    public class PestController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetPest(int pestId)
        {
            return null;
        }

        public ActionResult GetAllPestByPesticideName(String pestcideName)
        {
            return null;
        }

        public ActionResult GetAllPestByCropName(String cropName)
        {
            return null;
        }
    }
}
