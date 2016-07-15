using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatalogOfFilms.Controllers
{
    public class FilmSelectionController : Controller
    {
        // GET: FilmSelection
        private Models.FilmsDBEntities db = new Models.FilmsDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FilmPage(string genre, int? decennary, float? min_rating, float? max_rating)
        {
            var film = db.Films.Where(x => x.Genre.Equals(genre) && x.Decennary.Equals(decennary) && ((x.Rating < max_rating) && (x.Rating > min_rating)));
            return View(film);
        }
    }
}