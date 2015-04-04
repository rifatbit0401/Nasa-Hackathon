using System.Data.Entity;
using NasaHeckathonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Repository
{
    public class QuestionRepository
    {
        private NasaDbContext _nasaDbContext;
        public QuestionRepository()
        {
            _nasaDbContext = new NasaDbContext();
        }
        public int Add(Question question)
        {
            _nasaDbContext.Questions.Add(question);
             _nasaDbContext.SaveChanges();
            return question.Id;
        }

        public bool Edit(Question   question)
        {
            _nasaDbContext.Entry(question).State=EntityState.Modified;
            return _nasaDbContext.SaveChanges() > 0;
        }
        public List<Question> GetAllByUserId(int userId)
        {
            return _nasaDbContext.Questions.Where(q => q.UserId.Equals(userId)).ToList();
        }

        public List<Question>GetAllByCropName(String cropName)
        {
            return _nasaDbContext.Questions.Where(q => q.CropName.Equals(cropName)).ToList();
        }

        public List<Question> GetAllByPestName(String pestName)
        {
            return _nasaDbContext.Questions.Where(q => q.PestName.Equals(pestName)).ToList();
        }


    }
}