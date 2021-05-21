using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Dal.User
{
    public abstract class dCore
    {
        protected DBContext db;

        public dCore (DBContext db)
        {
            this.db = db;
        }
    }
}
