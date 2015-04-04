using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public double CurrentLatitude { get; set; }
        public double CurrentLongitute { get; set; }
        public String PestName { get; set; }
        //public String NameOfDesease { get; set; }
        public DateTime PestStartDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public String CropName { get; set; }
        public double HarvestArea { get; set; }
        public DateTime CulivationStartDate { get; set; }
        public DateTime CultivationFinishDate { get; set; }
        public Double AffectedArea { get; set; }
        public String PesticideName { get; set; }
        public String PesticideDescription { get; set; }
        public String Description { get; set; } 

    }
}