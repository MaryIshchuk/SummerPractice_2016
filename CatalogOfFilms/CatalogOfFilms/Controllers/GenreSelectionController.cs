using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatalogOfFilms.Controllers
{
    public class GenreSelectionController : Controller
    {
        // GET: GenreSelection
        public ActionResult Selection()
        {
            return View();
        }
    }
}