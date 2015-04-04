using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NasaHeckathonApp.Models;

namespace NasaHeckathonApp.Repository
{
    public class NasaDbContext : DbContext
    {
        public NasaDbContext()
            : base("name=NasaDbConnection")
        {

        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}