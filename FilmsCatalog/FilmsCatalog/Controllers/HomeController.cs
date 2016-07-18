using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmsCatalog.Models;

namespace FilmsCatalog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            var homeModel = new HomeModel
            {
                Films = DataBase.GetAllFilms(),
            };

            return View(homeModel);
        }
    }
}