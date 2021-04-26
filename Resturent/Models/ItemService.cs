using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Resturent.Models
{
    public class ItemService
    {
        public readonly OmDemoContext _db;

        public ItemService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<Item> GetItem()
        {
            var itemlist = _db.Items.ToList();
            return itemlist;
        }


        //Insert

        public bool Create(Item objItem)
        {
            _db.Items.Add(objItem);
            _db.SaveChanges();
            return true;
        }

        //get user by ID

        public Item GetItemById(int id)
        {
            Item item = _db.Items.FirstOrDefault(s => s.ItemId == id);
            return item;
        }

        //Update
        public string Update(Item objItem)
        {
            _db.Items.Update(objItem);
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

        public string Delete(long ItemId)
        {
            var item = _db.Items.FirstOrDefault(s => s.ItemId == ItemId);
            if (item != null)
            {
                _db.Items.Remove(item);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
