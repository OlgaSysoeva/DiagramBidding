using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiagramBidding.Models;

namespace DiagramBidding.Models
{
    public class LineChart
    {
        public string currency { get; set; }
        public List<double> price { get; set; }
        public List<DateTime> date { get; set; }
        public LineChart()
        {
            price = new List<double>();
            date = new List<DateTime>();
        }
        public void FindTrades(string namecurrency, List<HandbkTrade> trades)
        {
            var tradecurrency = trades
                .Select(x => new
                {
                    x.Price,
                    x.Date.Date,
                    x.Tool.Currency
                })
                .Where(x => x.Currency == namecurrency)
                .OrderBy(x => x.Date)
                .ToList();
            foreach (var item in tradecurrency)
            {
                currency = item.Currency;
                price.Add(item.Price);
                date.Add(item.Date);
            }
        }
    }
}