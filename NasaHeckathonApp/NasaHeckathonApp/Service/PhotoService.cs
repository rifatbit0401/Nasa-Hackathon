using System.Web;
using NasaHeckathonApp.Models;
using NasaHeckathonApp.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace NasaHeckathonApp.Service
{
    public class PhotoService
    {
        private PhotoRepository _photoRepository;

        public PhotoService()
        {
            _photoRepository=new PhotoRepository();
        }

        public int AddPhoto(Photo photo)
        {
            //var path=Path.Combine(Server)
            //PhotoPath.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Upload"), photo.Name);
            //var path = Path.Combine(Server.MapPath("~/Upload"), "");
            return _photoRepository.Add(photo);
        }

        public bool UpdatePhoto(Photo photo)
        {
            return _photoRepository.Edit(photo);
        }

        public bool DeletePhoto(Photo photo)
        {
            return _photoRepository.Delete(photo);
        }

        public List<Photo>GetPhotoByQuestionId(int questionId)
        {
            var photos = _photoRepository.GetPhotoByQuestionId(questionId);
            HttpServerUtility server = System.Web.HttpContext.Current.Server;
            foreach (var photo in photos)
            {
                photo.Path = Path.Combine(server.MapPath("~/Upload"), photo.Name);
            }
            return photos;//_photoRepository.GetPhotoByQuestionId(questionId);
        }

        public List<Photo>GetPhotoByAnswerId(int answerId)
        {
            var photos= _photoRepository.GetPhotoByAnswerId(answerId);
            HttpServerUtility server = System.Web.HttpContext.Current.Server;
            foreach (var photo in photos)
            {
                photo.Path = Path.Combine(server.MapPath("~/Upload"), photo.Name);
            }
            return photos;
        }

        public Photo GetPhotoByUserId(int userId)
        {
            var photo= _photoRepository.GetPhotoByUserId(userId);
            HttpServerUtility server = System.Web.HttpContext.Current.Server;
            photo.Path = Path.Combine(server.MapPath("~/Upload"), photo.Name);
           
            return photo;
        }

    }
}