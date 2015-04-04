using NasaHeckathonApp.Models;
using NasaHeckathonApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionService _questionService =new QuestionService();
 
        [AllowAnonymous]
        [HttpPost]
        public ActionResult AddQuestion(Question question)
        {
            int id=_questionService.AddQuestion(question);
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        [HttpPost]
        public void UpdateQuestion(Question question)
        {
            _questionService.UpdateQuestion(question);
        }

        [AllowAnonymous]
        [HttpGet]
        public JsonResult GetAllQuestionByUserId(int userId)
        {
            return Json(_questionService.GetAllQuestionByUserId(userId), JsonRequestBehavior.AllowGet);
        }

    }
}
