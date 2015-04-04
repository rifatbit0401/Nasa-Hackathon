using NasaHeckathonApp.Models;
using NasaHeckathonApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Service
{
    public class AnswerService
    {
        private AnswerRepository _answerRepository;
        
        public AnswerService()
        {
            _answerRepository=new AnswerRepository();
        }

        public int AddAnswer(Answer answer)
        {
           return _answerRepository.Add(answer);
        }

        public bool UpdateAnswer(Answer answer)
        {
            return _answerRepository.Edit(answer);
        }

        public List<Answer>GetAllAnswerByQuestionId(int questionId)
        {
            return _answerRepository.GetAllByQuestionId(questionId);
        }

        public List<Answer>GetAllAnswerByUserId(int userId)
        {
            return _answerRepository.GetAllByUserId(userId);
        }
    }
}