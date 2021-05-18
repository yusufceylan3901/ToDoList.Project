﻿ using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Linq;

namespace DAL.Note
{
    public class dNote
    {
        public rNote InsertNote(pNote args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    TblNote note = new TblNote()
                    {
                        Title = args.Title,
                        Note = args.Note,
                        Userid = args.UserId
                    };
                    db.TblNotes.Add(note);
                    db.SaveChanges();
                    return new rNote { Value = note };
                }
            }
            catch (Exception ex)
            {
                return new rNote { Error = true, Message = ex.Message };
            }
        }

        public rNote DeleteNote(pNote args)
        {
            using (DBContext db = new DBContext())
            {
                try
                {
                    
                    var note = db.TblNotes.Where(x => x.Noteid == args.NoteId).SingleOrDefault();                   
                    db.TblNotes.Remove(note);
                    db.SaveChanges();
                    return new rNote { Value=note };
                }
                catch (Exception ex)
                {
                    return new rNote { Error = true, Message = ex.Message };
                }
            }
        }

        public rNote UpdateNote(pNote args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var note = db.TblNotes.Where(x => x.Noteid == args.NoteId).SingleOrDefault();
                    //note.Title = args.Title;
                    note.Note = args.Note;
                    db.TblNotes.Update(note);
                    db.SaveChanges();
                    return new rNote();
                };
            }
            catch (Exception ex)
            {
                return new rNote { Error = true, Message = ex.Message };
            }
        }

        public rListNote ListNote(pNote args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var notes = db.TblNotes.Where(i => i.Userid == args.UserId).ToList();
                    return new rListNote { Values = notes };
                }
            }
            catch (Exception ex)
            {
                return new rListNote { Error = true, Message = ex.Message }; //****//
            }
        }

        public rNote Get(pNote args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var note = db.TblNotes.Where(x => x.Noteid == args.NoteId).SingleOrDefault();
                    return new rNote { Value = note };
                }
            }
            catch (Exception ex)
            {
                return new rNote {Error=true,Message=ex.Message};
            }
        }

        



    }
}
