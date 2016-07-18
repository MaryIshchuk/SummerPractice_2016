using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FilmsCatalog.App_Data;
using System.ComponentModel.DataAnnotations;

namespace FilmsCatalog.Models
{
    public class HomeModel
    {
        [Required(ErrorMessage = "*")]
        public string Login { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }

        public Film[] Films { get; set; }
        public Film film { get; set; }
    }
}