using NasaHeckathonApp.Models;
using NasaHeckathonApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Service
{
    public class RankService
    {
        private RankRepository _rankRepository;
        private QuestionRepository _questionRepository;
        private AnswerRepository _answerRepository;

        public RankService()
        {
            _rankRepository=new RankRepository();
            _questionRepository=new QuestionRepository();
            _answerRepository=new AnswerRepository();
        }

        public bool RankQuestion(Rank rank)
        {
            bool userRanked =_rankRepository.GetRankByUserId(rank.UserId).Any(
                r => r.UserId.Equals(rank.UserId) & r.QuestionId.Equals(rank.QuestionId));

            if(!userRanked)
            {
                _rankRepository.Add(rank);
                return false;
            }
            _rankRepository.Edit(rank);
            return true;
        }

        public bool RankAnswer(Rank rank)
        {
            bool userRanked = _rankRepository.GetRankByUserId(rank.UserId).Any(
                r => r.UserId.Equals(rank.UserId) & r.AnswerId.Equals(rank.AnswerId));

            if (!userRanked)
            {
                _rankRepository.Add(rank);
                return false;
            }
            _rankRepository.Edit(rank);
            return true;
        }
        public int GetTotalPositiveRankOfQuestion(int questionId)
        {
           return _rankRepository.GetRankByQuestionId(questionId).Where(r=>r.Point>0).Sum(r => r.Point);
        }

        public int GetTotalNegativeRankOfQuestion(int questionId)
        {
            return _rankRepository.GetRankByQuestionId(questionId).Where(r=>r.Point<0).Sum(r => r.Point);
        }

        public int GetTotalPositiveRankOfAnswer(int answerId)
        {
            return _rankRepository.GetRankByAnswerId(answerId).Where(r => r.Point > 0).Sum(r => r.Point);
        }

        public int GetTotalNegativeRankOfAnswer(int answerId)
        {
            return _rankRepository.GetRankByAnswerId(answerId).Where(r => r.Point < 0).Sum(r => r.Point);
        }

        public int GetTotalRankForQuestionByUserId(int userId)
        {
            var questions=_questionRepository.GetAllByUserId(userId);
            int point = 0;
            foreach(var question in questions)
            {
                point+=_rankRepository.GetRankByQuestionId(question.Id).Sum(r => r.Point);
            }
            return point;
        }

        public int GetTotalRankForAnswerByUserId(int userId)
        {
            var answers = _answerRepository.GetAllByUserId(userId);
            int point = 0;
            foreach(var answer in answers)
            {
                point+=_rankRepository.GetRankByAnswerId(answer.Id).Sum(r => r.Point);
            }
            return point;
        }
    }
}