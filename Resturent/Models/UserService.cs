using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public class UserService
    {
        private readonly OmDemoContext _db;

        public UserService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<User>GetUser()
        {
            var userList = _db.Users.ToList();
            return userList;
        }

        //Insert

        public string Create(User objUser)
        {
            _db.Users.Add(objUser);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public User GetUserById(int id)
        {
            User user = _db.Users.FirstOrDefault(s => s.UserId == id);
            return user;
        }

        //Update
        public string Update(User objUser)
        {
            _db.Users.Update(objUser);
            _db.SaveChanges();
            return "Update successfully";
        }

        //Delete
        /* public string Delete(User objUser)
         {
             _db.Remove(objUser);
             _db.SaveChanges();
             return "deleted";
         }*/

        public string Delete(long UserId)
        {
            var user = _db.Users.FirstOrDefault(s => s.UserId == UserId);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
