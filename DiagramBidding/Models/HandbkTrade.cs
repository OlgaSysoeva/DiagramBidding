using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagramBidding.Models
{
    public class HandbkTrade
    {
        // ID сделки
        public int Id { get; set; }
        // ID валюты
        public int ToolId { get; set; }
        // цена
        public float Price { get; set; }
        // объем
        public int Size { get; set; }
        // время сделки
        public DateTime Date { get; set; }
        // ID участника-покупателя
        public int CustomerId { get; set; }
        // ID участника-продавца
        public int SellerId { get; set; }
    }
}