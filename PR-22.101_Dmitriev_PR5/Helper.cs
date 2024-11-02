using PR_22._101_Dmitriev_PR5.Models;
using System.Collections.Generic;
using System.Linq;

namespace PR_22._101_Dmitriev_PR5
{
    internal class Helper
    {
        private static ProgMod_PZ4Entities _context;

        public static ProgMod_PZ4Entities GetContext()
        {
            if (_context == null)
            {
                _context = new ProgMod_PZ4Entities();
            }
            return _context;
        }


        public static void CreateUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public static void UpdateUser(User user) 
        {
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public static void RemoveUser(int idUser)
        {
            var users = _context.User.Find(idUser);
            _context.User.Remove(users);
            _context.SaveChanges();
        }

        public static List<User> FilterUsers()
        {
            return _context.User.Where(x => x.Login.StartsWith("M") || x.Login.StartsWith("А")).ToList();
        }

        public static List<User> SortUsers()
        {
            return _context.User.OrderBy(x => x.Login).ToList();
        }
    }
}
