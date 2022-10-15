using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private GameStoreEntities1 entity = new GameStoreEntities1();
        // GET: Admin
        [Authorize(Roles ="Admin, A12345!")]
        public ActionResult Index()
        {
            return View();
        }
    }
}