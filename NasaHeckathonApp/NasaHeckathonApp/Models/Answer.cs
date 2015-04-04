using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public String Description { get; set; }
        public String PestName { get; set; }
        public String PestDescription { get; set; }
        public String PesticideName { get; set; }
        public String PesticideDescription { get; set; }


    }
}