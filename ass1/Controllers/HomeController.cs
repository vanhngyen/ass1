using ass1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ass1.Controllers
{
    public class HomeController : Controller
    {
        DealAndAccountContext db = new DealAndAccountContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Accounts.ToList();
            return View(data);
        }
    }
}