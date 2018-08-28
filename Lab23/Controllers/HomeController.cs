using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeShopDBEntities ORM = new CoffeShopDBEntities();
            ViewBag.Items = ORM.Items.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddUser()
        {
            CoffeShopDBEntities ORM = new CoffeShopDBEntities();
            ViewBag.User = ORM.Users.ToList();
            return View();

        }
        public ActionResult SignUp()
        {
            return View();

        }
    }
}