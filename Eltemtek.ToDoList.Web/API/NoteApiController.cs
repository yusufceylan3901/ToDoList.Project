using DAL.Note;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Eltemtek.ToDoList.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteApiController : ControllerBase
    {

        [HttpGet]
        [Route("Get")]
        public rNote Get(pNote args)
        {
            dNote note = new dNote();

            return note.Get(args);
        }


        [HttpPost]
        [Route("Insert")]
        public rNote Insert(pNote args)
        {
            args.UserId = Convert.ToInt32(HttpContext.Session.GetString("session"));

            dNote note = new dNote();

            return note.InsertNote(args);

        }


        [HttpPost]
        [Route("Update")]
        public rNote Update(pNote args)
        {
            dNote note = new dNote();

            return note.UpdateNote(args);
        }


        [HttpPost]
        [Route("Delete")]
        public rNote Delete(pNote args)
        {           
            dNote note = new dNote();

            return note.DeleteNote(args);
        }

        [HttpPost]
        [Route("List")]
        public rListNote List(pNote args)
        {
            dNote noteD = new dNote();

            return noteD.ListNote(args);
        }


    }
}
