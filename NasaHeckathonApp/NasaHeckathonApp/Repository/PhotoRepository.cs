using System.Data.Entity;
using NasaHeckathonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Repository
{
    public class PhotoRepository
    {
        private NasaDbContext _nasaDbContext;

        public PhotoRepository()
        {
            _nasaDbContext=new NasaDbContext();
        }
        public int Add(Photo photo)
        {
            _nasaDbContext.Photos.Add(photo);
            _nasaDbContext.SaveChanges();
            return photo.Id;
        }

        public bool Edit(Photo photo)
        {
            _nasaDbContext.Entry(photo).State = EntityState.Modified;
            return _nasaDbContext.SaveChanges() > 0;
        }

        public bool Delete(Photo photo)
        {
            _nasaDbContext.Entry(photo).State=EntityState.Deleted;
            return _nasaDbContext.SaveChanges() > 0;
        }

        public List<Photo>GetPhotoByQuestionId(int questionId)
        {
            return _nasaDbContext.Photos.Where(p => p.QuestionId.Equals(questionId)).ToList();
        }

        public Photo GetPhotoByUserId(int userId)
        {
            return _nasaDbContext.Photos.SingleOrDefault(p => p.UserId.Equals(userId));
        }

        public List<Photo>GetPhotoByAnswerId(int answerId)
        {
            return _nasaDbContext.Photos.Where(p => p.AnswerId.Equals(answerId)).ToList();
        }
    }
}