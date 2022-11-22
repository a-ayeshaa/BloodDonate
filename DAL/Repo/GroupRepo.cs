using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class GroupRepo : IRepo<Group, int, Group>
    {
        BloodDonorEntities db;

        public GroupRepo()
        {
            db = new BloodDonorEntities();
        }
        public Group Add(Group obj)
        {
            db.Groups.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var val = db.Groups.Find(id);
            db.Groups.Remove(val);
            return db.SaveChanges() > 0;
            
        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public bool Update(Group obj)
        {
            var dbobj = db.Groups.Find(obj.id);
            db.Entry(dbobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
