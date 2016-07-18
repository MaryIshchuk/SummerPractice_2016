using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmsCatalog.Models;

namespace FilmsCatalog.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult ShowFilms()
        {
            var homeModel = new HomeModel
            {
                Films = DataBase.GetAllFilms(),
            };

            return View(homeModel);
        }
    }
}