using NasaHeckathonApp.Models;
using NasaHeckathonApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    public class AnswerController : Controller
    {
        private AnswerService _answerService=new AnswerService();

        [HttpPost]
        [AllowAnonymous]
        public ActionResult AddAnswer(Answer answer)
        {
            int id=_answerService.AddAnswer(answer);
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AllowAnonymous]
        public void UpdateAnswer(Answer answer)
        {
            _answerService.UpdateAnswer(answer);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetAllAnswerByQuestionId(int questionId)
        {
            return Json(_answerService.GetAllAnswerByQuestionId(questionId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetAllAnswerByUserId(int userId)
        {
            return Json(_answerService.GetAllAnswerByUserId(userId), JsonRequestBehavior.AllowGet);
        }
    }
}
