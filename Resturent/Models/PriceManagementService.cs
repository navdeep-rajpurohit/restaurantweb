using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


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
        public string Update(PriceManagement objPriceManagement,long CurrentId,long? VariationId)

        {
            PriceManagement idlist = _db.PriceManagements.Where(c => (c.ItemId == CurrentId) && (c.VariationId == VariationId)).FirstOrDefault();
            if (idlist == null)
            {
                 objPriceManagement.PriceId = 0;
                _db.PriceManagements.Add(objPriceManagement);
            }
            else if (idlist.ItemId == CurrentId && idlist.VariationId == VariationId)
            {
                idlist.VariationId = objPriceManagement.VariationId;
                idlist.VariationAmount = objPriceManagement.VariationAmount;   
            }
            _db.SaveChanges();
            return "Update successfully";
        }
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
        public string DeleteVariation(List<long?> DeleteVarId,long CurrentId)
        {
            var varId = _db.PriceManagements.FirstOrDefault(s => s.ItemId == CurrentId);
            if (varId != null)
            {
                foreach (long i in DeleteVarId)
                {
                    _db.PriceManagements.RemoveRange(_db.PriceManagements.Where(c => c.ItemId == CurrentId && c.VariationId == i));
                }
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
