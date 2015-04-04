using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NasaHeckathonApp.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public int ImageId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}