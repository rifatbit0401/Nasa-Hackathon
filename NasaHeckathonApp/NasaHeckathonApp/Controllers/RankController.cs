using NasaHeckathonApp.Models;
using NasaHeckathonApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NasaHeckathonApp.Controllers
{
    public class RankController : Controller
    {
        private RankService _rankService = new RankService();

        [HttpPost]
        [AllowAnonymous]
        public void RankQuestion(Rank rank)
        {
            _rankService.RankQuestion(rank);
        }

        [HttpPost]
        [AllowAnonymous]
        public void RankAnswer(Rank rank)
        {
            _rankService.RankAnswer(rank);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetTotalPositiveRankOfQuestion(int questionId)
        {
            return Json(_rankService.GetTotalPositiveRankOfQuestion(questionId), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetTotalNegativeRankOfQuestion(int questionId)
        {
            return Json(_rankService.GetTotalNegativeRankOfQuestion(questionId),JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetTotalPositiveRankOfAnswer(int answerId)
        {
            return Json(_rankService.GetTotalPositiveRankOfAnswer(answerId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetTotalNegativeRankOfAnswer(int answerId)
        {
            return Json(_rankService.GetTotalNegativeRankOfAnswer(answerId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetTotalRankForQuestionByUserId(int userId)
        {
            return Json(_rankService.GetTotalRankForQuestionByUserId(userId), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetTotalRankForAnswerByUserId(int userId)
        {
            return Json(_rankService.GetTotalRankForAnswerByUserId(userId), JsonRequestBehavior.AllowGet);
        }

    }
}
