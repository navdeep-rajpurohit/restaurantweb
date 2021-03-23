using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public class VariationService
    {
        private readonly OmDemoContext _db;

        public VariationService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<Variation> GetVariation()
        {
            var variationList = _db.Variations.ToList();
            return variationList;
        }

        //Insert

        public string Create(Variation objVariation)
        {
            _db.Variations.Add(objVariation);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public Variation GetVariationById(int id)
        {
            Variation variation = _db.Variations.FirstOrDefault(s => s.VariationId == id);
            return variation;
        }

        //Update
        public string Update(Variation objVariation)
        {
            _db.Variations.Update(objVariation);
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

        public string Delete(long VariationId)
        {
            var variation = _db.Variations.FirstOrDefault(s => s.VariationId == VariationId);
            if (variation != null)
            {
                _db.Variations.Remove(variation);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
