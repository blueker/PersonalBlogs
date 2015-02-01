using System;
using System.Data.Entity;

namespace PersonalBlog.Models
{
    public class Movie
    {
        public string id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public DateTime pubdate { get; set; }
        public string desc { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> movies { get; set; }
    }
}