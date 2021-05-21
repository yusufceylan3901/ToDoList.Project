using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DAL.User;
using DAL;
using System;
using DAL.Note;

namespace Eltemtek.ToDoList.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetString("session");
            dUser userD = new dUser();

            var user = userD.Get(new pId { Id = Convert.ToInt32(userId) });
            return View(user);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult NoteList()
        {
            var userId = HttpContext.Session.GetString("session");
            if (userId != null)
            {
                dNote noteD = new dNote();

                var noteList = noteD.ListNote(new pNote { UserId = Convert.ToInt32(userId) });
                ViewBag.UserId = userId;
                return View(noteList);
            }
            else
                return RedirectToAction("Login", "Home");
        }

        public IActionResult UpdateNote()
        {
            var userId = HttpContext.Session.GetString("session");
            if (userId != null)
            {
                dNote noteD = new dNote();

                var noteList = noteD.ListNote(new pNote { UserId = Convert.ToInt32(userId) });

                return View(noteList);
            }
            else
                return RedirectToAction("Login", "Home");
        }

        public IActionResult Profile()
        {
            var userId = HttpContext.Session.GetString("session");
            if (userId != null)
            {
                dUser userD = new dUser();
                var user = userD.Get(new pId { Id = Convert.ToInt32(userId) });
                ViewBag.UserId = userId;
                return View(user);
            }
            else
                return RedirectToAction("Login", "Home");
        }

        public IActionResult DeleteProfile()
        {
            var userId = HttpContext.Session.GetString("session");
            dUser userD = new dUser();
            var user = userD.Get(new pId { Id = Convert.ToInt32(userId) });
            ViewBag.Id = userId;
            user = userD.DeleteUser(new pId { Id = Convert.ToInt32(userId) });

            if (user != null)
            {
                return View();

            }
            return RedirectToAction("Login","Home");

        }
        public IActionResult Authenticate()
        {
            return RedirectToAction("Login");
        }

    }
}
