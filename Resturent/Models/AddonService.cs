using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public class AddonService
    {
        private readonly OmDemoContext _db;

        public AddonService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<Addon> GetAddon()
        {
            var addonList = _db.Addons.ToList();
            return addonList;
        }

        //Insert

        public string Create(Addon objAddon)
        {
            _db.Addons.Add(objAddon);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public Addon GetAddonById(int id)
        {
            Addon addon = _db.Addons.FirstOrDefault(s => s.AddonId == id);
            return addon;
        }

        //Update
        public string Update(Addon objAddon)
        {
            _db.Addons.Update(objAddon);
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

        public string Delete(long AddonId)
        {
            var addon = _db.Addons.FirstOrDefault(s => s.AddonId == AddonId);
            if (addon != null)
            {
                _db.Addons.Remove(addon);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
