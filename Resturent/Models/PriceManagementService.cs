using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public  class PriceManagementService
    {
        public readonly OmDemoContext _db;

        public PriceManagementService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<PriceManagement> GetPriceManagement()
        {
            var PriceManagementList = _db.PriceManagements.ToList();
            return PriceManagementList;
        }

        //Insert

        public string Create(PriceManagement objPriceManagement)
        {
            _db.PriceManagements.Add(objPriceManagement);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public PriceManagement GetPriceManagementById(int id)
        {
            PriceManagement priceManagement = _db.PriceManagements.FirstOrDefault(s => s.PriceId == id);
            return priceManagement;
        }

        //Update
        public string Update(PriceManagement objPriceManagement)
        {
            _db.PriceManagements.Update(objPriceManagement);
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

        public string Delete(long? ItemId)
        {
            var pricemanagement = _db.PriceManagements.FirstOrDefault(s => s.ItemId == ItemId);
            if (pricemanagement != null)
            {
                _db.PriceManagements.RemoveRange(_db.PriceManagements.Where(c => c.ItemId == ItemId)); 
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
