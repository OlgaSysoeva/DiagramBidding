using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiagramBidding.Models;
using Highsoft.Web.Mvc.Charts;

namespace DiagramBidding.Controllers
{
    public class HomeController : Controller
    {
        DBContext db = new DBContext();

        public ActionResult Index()
        {
            IEnumerable<Tool> tools = db.Tools;
            ViewBag.Tools = tools;
            return View();
        }
       
        public ActionResult Razor()
        {
            var trades = db.HandbkTrades.ToList();            
            return View(trades);
        }

        public ActionResult ShowChart()
        {
            var currency = TradeCurrency();
            ViewBag.currency = currency;
            return View();
        }

        public ActionResult ChartJSON()
        {
            var currency = TradeCurrency();
            return Json(currency, JsonRequestBehavior.AllowGet);
        }

        public List<LineChart> TradeCurrency()
        {
            var trades = db.HandbkTrades.ToList();
            var dbcurrency = db.HandbkTrades
                .GroupBy(x => x.Tool.Currency)
                .Select(x => new
                {
                    Currency = x.Key
                })
                .ToList();
            var currency = new List<LineChart>();
            foreach (var item in dbcurrency)
            {
                var line = new LineChart();
                line.FindTrades(item.Currency, trades);
                currency.Add(line);
            }
            return currency;
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