using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo:IRepo<User,string,User>,IAuth
    {
        BloodDonorEntities db;

        public UserRepo()
        {
            db = new BloodDonorEntities();
        }

        public User Authenticate(string username, string password)
        {
            var user= db.Users.FirstOrDefault(u=>u.username.Equals(username) && u.password.Equals(password));
            if (user!=null)
                return user;
            return null;
        }
        public User Add(User obj)
        {
            db.Users.Add(obj);
            db.SaveChanges();
            return obj;
        }

        

        public bool Delete(string id)
        {
            var val = db.Users.Find(id);
            db.Users.Remove(val);
            return db.SaveChanges() > 0;

        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(string id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var dbobj = db.Users.Find(obj.username);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
