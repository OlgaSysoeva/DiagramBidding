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
            ViewBag.Tools = tools;
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

        public ActionResult Razor()
        {
            var trades = db.HandbkTrades.ToList();
            return View(trades);
        }

        public ActionResult Ajax()
        {
            return View();
        }

        public JsonResult JsonTrades()
        {
            var jsondata = db.HandbkTrades
                .Select(x => new
                {
                    Currency = x.Tool.Currency,
                    Price = x.Price,
                    Size = x.Size,
                    Date = x.Date,
                    Customer = x.Customer.Name,
                    Seller = x.Seller.Name
                })
                .ToList();
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
    }
}