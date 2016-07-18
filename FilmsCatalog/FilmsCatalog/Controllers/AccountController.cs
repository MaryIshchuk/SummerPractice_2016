using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web;
using System.Web.Mvc;
using FilmsCatalog.Models;
using FilmsCatalog.App_Data;

namespace FilmsCatalog.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(HomeModel homeModel)
        {
            User user = DataBase.GetUser(homeModel.Login,
                    Helpers.SecurityHelper.Hash(homeModel.Password));
            if (user != null)
            {
                Helpers.AuthHelper.LogInUser(HttpContext, user.Cookies);

                switch (user.Role.RoleName)
                {
                    case "Admin":
                        return RedirectToAction("Admin", "Admin");
                    case "User":
                        return RedirectToAction("HomePage", "Home");
                }

            }
            return RedirectToAction("HomePage", "Home");
        }

        public ActionResult LogOff()
        {
            Helpers.AuthHelper.LogOffUser(HttpContext);

            return RedirectToAction("HomePage", "Home");
        }
    }
}