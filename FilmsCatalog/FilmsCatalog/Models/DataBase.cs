using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FilmsCatalog.App_Data;

namespace FilmsCatalog.Models
{
    public static class DataBase
    {
        public static Film[] GetAllFilms()
        {
            var entity = new FilmsDBEntities();

            return entity.Films.ToArray();
        }

        public static Film[] GetSelectedFilms(string genre, int decennary, float min_rating)
        {
            var entity = new FilmsDBEntities();
            if (entity.Films.Where(x => x.Genre1.GenreName.Equals(genre) && x.Decennary == decennary && (x.Rating > min_rating)).ToArray() == null)
            {
                return entity.Films.Where(x => x.Genre1.GenreName.Contains(genre) && x.Decennary == decennary && (x.Rating > min_rating)).ToArray();
            }
            else return entity.Films.Where(x => x.Genre1.GenreName.Contains(genre)).ToArray();
        }
        
        public static User GetUserByCookeis(string cookies)
        {
            var entity = new FilmsDBEntities();

            return entity.Users.FirstOrDefault(u => u.Cookies == cookies);
        }

        public static void AddUser(User user)
        {
            var entity = new FilmsDBEntities();
            user.RoleId = 2; // number 2 - role User (number 1 - Admin)  
            user.Cookies = Guid.NewGuid().ToString(); // cookie for auth
            entity.Users.Add(user);
            entity.SaveChanges();
        }

        public static User GetUser(string login, string password)
        {
            var entity = new FilmsDBEntities();

            return entity.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }

    }
}