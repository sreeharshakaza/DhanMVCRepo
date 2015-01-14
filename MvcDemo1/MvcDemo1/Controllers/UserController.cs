using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo1.Models;

namespace MvcDemo1.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private static Users users = new Users();

        public ActionResult Index()
        {
            return View(users.userList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModels userModel)
        {
            users.AddUser(userModel);
            return RedirectToAction("Index");
        }

        public ActionResult UserList()
        {
            return View(users.userList);
        }

        public PartialViewResult PartialUserList()
        {
            return PartialView("_UserPartial", users.userList);
        }
    }
}
