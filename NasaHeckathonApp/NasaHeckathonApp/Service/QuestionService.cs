using NasaHeckathonApp.Models;
using NasaHeckathonApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Service
{
    public class QuestionService
    {
        private QuestionRepository _questionRepository;
        
        public QuestionService()
        {
            _questionRepository = new QuestionRepository();
        }

        public int AddQuestion(Question question)
        {
           return _questionRepository.Add(question);
        }

        public bool UpdateQuestion(Question question)
        {
            return _questionRepository.Edit(question);
        }

        public List<Question>GetAllQuestionByUserId(int userId)
        {
            return _questionRepository.GetAllByUserId(userId);
        }

        public List<Question> GetAllQuestionByPestName(String pestName)
        {
            return _questionRepository.GetAllByPestName(pestName);
        }
    }
}