using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturent.Models
{
    public  class TableService
    {
        private readonly OmDemoContext _db;

        public TableService(OmDemoContext db)
        {
            _db = db;
        }

        //crud
        //display all user
        public List<Table> GetTable()
        {
            var tableList = _db.Tables.ToList();
            return tableList;
        }

        //Insert

        public string Create(Table objTable)
        {
            _db.Tables.Add(objTable);
            _db.SaveChanges();
            return "save successfully";
        }

        //get user by ID

        public Table GetTableById(int id)
        {
            Table table = _db.Tables.FirstOrDefault(s => s.TableId == id);
            return table;
        }

        //Update
        public string Update(Table objTable)
        {
            _db.Tables.Update(objTable);
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

        public string Delete(long TableId)
        {
            var table = _db.Tables.FirstOrDefault(s => s.TableId == TableId);
            if (table != null)
            {
                _db.Tables.Remove(table);
                _db.SaveChanges();
            }
            return "Deleted";
        }

    }
}
