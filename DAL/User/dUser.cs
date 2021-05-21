using DAL.User;
using Eltemtek.ToDoList.Db.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace DAL
{
    public class dUser
    {
        //Kullancı Ekleme Metodu Eklemeden Önce E-Mailin Geçerli Olup Olmadığını Kontrol Ettik..//
        public rUser InsertUser(pUser args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    if (!IsValidEMail(args.Email))
                        return new rUser { Error = true, Message = "Kullanıcı zaten kayıtlı" };

                    TblUser user = new TblUser()
                    {

                        Name = args.Name,
                        Surname = args.Surname,
                        Password = args.Password,
                        Email = args.Email
                    };

                    db.TblUsers.Add(user);
                    db.SaveChanges();
                    return new rUser { Value = user };
                }
            }
            catch (Exception ex)
            {
                return new rUser { Error = true, Message = ex.Message };
            }
        }

        //Kullancı Silme Metodu Id den yakalayıp veritabanından sildik..//
        public rUser DeleteUser(pId args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var user = db.TblUsers.Where(x =>x.Id == args.Id).SingleOrDefault();
                    db.TblUsers.Remove(user);
                    db.SaveChanges();
                    return new rUser();
                }
            }
            catch (Exception ex)
            {
                return new rUser { Error = true, Message = ex.Message };
            }
        }
        //Kullancı Güncelleme Metodu Id den kullanıcıyı bulup güncellenecek kısımı yaptık..//
        public rUser UpdatePassword(pUser args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var user = db.TblUsers.Where(x => x.Id == args.Id).SingleOrDefault();
                    user.Password = args.Password;
                    db.TblUsers.Update(user);
                    db.SaveChanges();
                    return new rUser();
                }
            }
            catch (Exception ex)
            {
                return new rUser { Error = true, Message = ex.Message };
            }

        }

        private bool IsValidEMail(string email)
        {
            try
            {
                using (DBContext db = new DBContext())
                {

                    var user = db.TblUsers.Where(x => x.Email == email).SingleOrDefault();

                    return user == null ? true : false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        //private bool IsValidPassword(string password)
        //{
        //    try
        //    {
        //        using (var db = new DBContext())
        //        {
        //            var user = db.TblUsers.Where(x => x.Password == password).SingleOrDefault();

        //            return user == null ? true : false;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}

        public rUser Get(pUser args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var user = db.TblUsers.Where(x => x.Id == args.Id).SingleOrDefault();
                    
                    return new rUser()
                    {
                        Value = user
                    };
                }
            }
            catch (Exception ex)
            {
                return new rUser { Error = true, Message = ex.Message };
            }
        }
           
        

        public rListUser ListUser(pUser args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    var user = db.TblUsers.Where(x => x.Id == args.Id).ToList();
                    return new rListUser {Values=user };
                }

            }
            catch (Exception ex)
            {

                return new rListUser { Error = true, Message = ex.Message };
            }

        }
        
        public string LoginControl(pUser args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {

                    var user = db.TblUsers.Where(x => x.Email == args.Email && x.Password == args.Password).SingleOrDefault();
                    

                    return user == null ? "" : user.Id + "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }


        


    }
}
