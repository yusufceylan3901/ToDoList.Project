using Eltemtek.ToDoList.Db.DataAccess;
using System.Collections.Generic;

namespace DAL.User
{
    public class rListUser:rCore
    {
        public List<TblUser> Values { get; set; }
    }
}
