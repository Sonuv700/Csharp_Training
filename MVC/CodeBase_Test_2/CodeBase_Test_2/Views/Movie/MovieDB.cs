using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeBase_Test_2.Views.Movie
{
    public class MoviesDB : DbContext
    {
        public MoviesDB() : base("MoviesDB")

        {

        }
        public DbSet<Movies> Movie { get; set; }

    }
}