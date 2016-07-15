using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatalogOfFilms.Models;

namespace CatalogOfFilms.Controllers
{
    public class ShowFilmsController : Controller
    {
        // GET: ShowFilms
        
        private FilmsDBEntities db = new FilmsDBEntities();

        public ActionResult ShowFilms()
        {
            var films = db.Films;
            ViewBag.Films = films;
            return View();
        }

    }
}