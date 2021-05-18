using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.User
{
   public class rListUser:rCore
    {
        public List<TblUser> Values { get; set; }
    }
}
