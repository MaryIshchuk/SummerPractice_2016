using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmsCatalog.Helpers;

namespace FilmsCatalog.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [PageAuthorize(UserRoles = "User")]
        public ActionResult UserAccount()
        {
            return View();
        }

    }
}