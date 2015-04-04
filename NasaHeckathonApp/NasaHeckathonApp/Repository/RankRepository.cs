using System.Data.Entity;
using NasaHeckathonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Repository
{
    public class RankRepository
    {
        private NasaDbContext _nasaDbContext;

        public RankRepository()
        {
            _nasaDbContext = new NasaDbContext();
        }

        public int Add(Rank rank)
        {
            _nasaDbContext.Ranks.Add(rank);
            _nasaDbContext.SaveChanges();
            return rank.Id;
        }
        public bool Edit(Rank rank)
        {
            _nasaDbContext.Entry(rank).State = EntityState.Modified;
            return _nasaDbContext.SaveChanges() > 0;
        }
        public bool Delete(Rank rank)
        {
            _nasaDbContext.Entry(rank).State = EntityState.Deleted;
            return _nasaDbContext.SaveChanges() > 0;
        }
        public List<Rank> GetRankByQuestionId(int questionId)
        {
            return _nasaDbContext.Ranks.Where(r => r.QuestionId.Equals(questionId)).ToList();
        }

        public List<Rank> GetRankByAnswerId(int answerId)
        {
            return _nasaDbContext.Ranks.Where(r => r.AnswerId.Equals(answerId)).ToList();
        }

        public List<Rank> GetRankByUserId(int userId)
        {
            return _nasaDbContext.Ranks.Where(r => r.UserId.Equals(userId)).ToList();
        }

    }
}