using NasaHeckathonApp.Models;
using NasaHeckathonApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    public class PhotoController : Controller
    {
        private PhotoService _photoService=new PhotoService();

        [AllowAnonymous]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            var filename = Path.GetFileName(file.FileName);
            if (filename != null)
            {
                var path = Path.Combine(Server.MapPath("~/Upload"), filename);
                file.SaveAs(path);
            }
            return Json(filename, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult AddPhoto(Photo photo)
        {
            return Json(_photoService.AddPhoto(photo),JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        public void UpdatePhoto(Photo photo)
        {
            _photoService.UpdatePhoto(photo);
        }


        [HttpPost]
        [AllowAnonymous]
        public void DeletePhoto(Photo photo)
        {
            _photoService.DeletePhoto(photo);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetPhotoByQuestionId(int questionId)
        {
            return Json(_photoService.GetPhotoByQuestionId(questionId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetPhotoByAnswerId(int answerId)
        {
            return Json(_photoService.GetPhotoByAnswerId(answerId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetPhotoByUserId(int userId)
        {
            return Json(_photoService.GetPhotoByUserId(userId), JsonRequestBehavior.AllowGet);
        }

    }
}
