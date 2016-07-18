using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmsCatalog.App_Data;
using FilmsCatalog.Models;

namespace FilmsCatalog.Controllers
{
    public class SelectionController : Controller
    {
        FilmsDBEntities db = new FilmsDBEntities();

        // GET: Selection
        public ActionResult Index()
        {
            return View();
        }        

        [HttpPost]
        public ActionResult FilmSelection(string genre, int decennary, float min_rating)
        {
            var homeModel = new HomeModel
            {
                Films = DataBase.GetSelectedFilms(genre,decennary,min_rating),
            };

            return View(homeModel);
        }
    }
}