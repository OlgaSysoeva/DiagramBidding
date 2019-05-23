using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiagramBidding.Models;

namespace DiagramBidding.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        DBContext db = new DBContext();

        public ActionResult Index()
        {
            IEnumerable<Tool> tools = db.Tools;
            ViewBag.Books = tools;
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
    }
}