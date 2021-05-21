 using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Linq;

namespace DAL.Note
{
    public class dNote
    {
        //Not Ekleme Metodu..//
        public rNote InsertNote(pNote args)
        {
            try
            {
                using (DBContext db = new DBContext()) // Veritabanı bağlantı nesnesi oluşturuluyor..//
                {
                    TblNote note = new TblNote()
                    {
                        Title = args.Title,
                        Note = args.Note,
                        Userid = args.UserId
                    };
                    db.TblNotes.Add(note);   //Veri tabanındaki TblNotes tablosuna ekleme yapıyor..//
                    db.SaveChanges();  //Veritabanındaki Değişiklikleri Kayıt Ediyor..//
                    return new rNote { Value = note };
                }
            }
            catch (Exception ex)
            {
                return new rNote { Error = true, Message = ex.Message };
            }
        }

        //Not Silme Metodu Notu id den yakalayıp siliyor..//
        
        public rNote DeleteNote(pNote args)
        {
            using (DBContext db = new DBContext())
            {
                try
                {
                    
                    var note = db.TblNotes.Where(x => x.Noteid == args.NoteId).SingleOrDefault();  //Veritabanındaki TblNotes tablosundaki notun id sini buluyor..//                
                    db.TblNotes.Remove(note);  //Veritabanındaki TblNotes tablosundan bulunan veriyi kaldırıyor..//
                    db.SaveChanges();  //Veritabanındaki Değişiklikleri Kayıt Ediyor..//
                    return new rNote { Value=note };
                }
                catch (Exception ex)
                {
                    return new rNote { Error = true, Message = ex.Message };
                }
            }
        }
        //Not Güncelleme Metodu Notu id den yakalayıp güncelliyor..//
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
        //Not Listeleme Metodu Burada kullanıcının id sini yakalayıp kullanıcının oluşturduğu notları listeliyor..//
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
        //Not Getirme Metodu..//
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
