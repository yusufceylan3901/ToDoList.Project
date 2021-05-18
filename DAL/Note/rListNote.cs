using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Note
{
    public class rListNote:rCore
    {
        public List<TblNote> Values { get; set; }
    }
}
