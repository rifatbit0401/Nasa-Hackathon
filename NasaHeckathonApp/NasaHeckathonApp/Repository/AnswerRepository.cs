using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NasaHeckathonApp.Models;

namespace NasaHeckathonApp.Repository
{
    public class AnswerRepository
    {
        private NasaDbContext _nasaDbContext;

        public AnswerRepository()
        {
            _nasaDbContext = new NasaDbContext();
        }

        public int Add(Answer answer)
        {
            _nasaDbContext.Answers.Add(answer);
            _nasaDbContext.SaveChanges();
            return answer.Id;
        }

        public bool Edit(Answer answer)
        {
            _nasaDbContext.Entry(answer).State = EntityState.Modified;
            return _nasaDbContext.SaveChanges() > 0;
        }

        public List<Answer>GetAllByQuestionId(int questionId)
        {
            return _nasaDbContext.Answers.Where(a => a.QuestionId.Equals(questionId)).ToList();
        }

        public List<Answer> GetAllByUserId(int userId)
        {
            return _nasaDbContext.Answers.Where(a => a.UserId.Equals(userId)).ToList();
        }
        

    }
}