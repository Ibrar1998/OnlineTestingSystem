using OnlineTestSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTestSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.RegisterUser registerUser  )
        {
            OnlineTestSystemEntities db = new OnlineTestSystemEntities();
            User u = new User();
            u.Password = registerUser.Password;
            u.Username = registerUser.Username;
            u.Email = registerUser.Email;
            u.Roleid = 2;
            db.Users.Add(u);
            db.SaveChanges();

            RedirectToAction("","Home","Index");

            return View();
        }

    }
}