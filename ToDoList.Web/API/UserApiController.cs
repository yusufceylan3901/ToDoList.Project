using DAL;
using DAL.User;
using Eltemtek.ToDoList.Db.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;

namespace Eltemtek.ToDoList.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {

        [HttpPost]
        [Route("Get")]
        public rUser Get(pUser args)
        {
            dUser user = new dUser();

            return user.Get(args);
        }

        [HttpPost]
        [Route("Insert")]
        public rUser Insert(pUser args)
        {

            dUser user = new dUser();

            return user.InsertUser(args);

        }


        [HttpPost]
        [Route("Update")]
        public rUser Update(pUser args)
        {
            dUser user = new dUser();

            return user.UpdatePassword(args);
        }


        [HttpPost]
        [Route("Delete")]
        public rUser Delete(pId args)
        {
            dUser user = new dUser();

            return user.DeleteUser(args);
        }

        //[HttpPost]
        //[Route("LoginControl")]
        //public string LoginControl(pUser args)
        //{
        //    var user = new dUser();

        //    return user.LoginControl(args);
        //}

        [HttpPost]
        [Route("LoginControl")]

        public bool LoginControl(pUser args)
        {
            dUser userD = new dUser();
            var userId = userD.LoginControl(args);

            if (!String.IsNullOrEmpty(userId))
            {
                HttpContext.Session.SetString("session", userId);

                return true;

            }

            else
                return false;
           
        }
    }
}

