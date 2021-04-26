using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{   
    public class CategoryService
    {
        public readonly OmDemoContext _db;

        public CategoryService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<Category> GetCategory()
        {
            var categorylist = _db.Categories.ToList();
            return categorylist;
        }

        //Insert

        public bool Create(Category objCategory)
        {
            _db.Categories.Add(objCategory);
            _db.SaveChanges();
            return true;
        }

        //get user by ID

        public Category GetCategoryById(int id)
        {
            Category category = _db.Categories.FirstOrDefault(s => s.CategoryId == id);
            return category;
        }

        //Update
        public string Update(Category objCategory)
        {
            _db.Categories.Update(objCategory);
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

        public string Delete(long CategoryId)
        {
            var category = _db.Categories.FirstOrDefault(s => s.CategoryId == CategoryId);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
            }
            return "Deleted";
        }

        
    }
}
