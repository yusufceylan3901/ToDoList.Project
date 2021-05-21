using DAL;
using DAL.User;
using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Bll.User
{
    public class bUser:dUser
    {
        public rUser Add(pUser args)
        {
            using (DBContext db = new DBContext())
            {
                dUser userD = new dUser();

                try
                {
                    return userD.InsertUser(args);
                }
                catch (Exception ex)
                {

                    return new rUser() { Error = true, Message = ex.Message };
                }
            }

        }
    }
}
