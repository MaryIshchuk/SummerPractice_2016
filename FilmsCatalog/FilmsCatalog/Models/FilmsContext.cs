using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FilmsCatalog.App_Data;
using System.Data.Entity;
using FilmsCatalog.Models;

namespace FilmsCatalog.Models
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Film> Genre { get; set; }
        public DbSet<Film> Decennary { get; set; }
        public DbSet<Film> Rating { get; set; }
    }
}