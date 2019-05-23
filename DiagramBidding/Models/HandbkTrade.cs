using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace DiagramBidding.Models
{
    public class HandbkTrade
    {
        // ID сделки
        [Key]
        public int Id { get; set; }
        // ID валюты
        [ForeignKey(nameof(Tool))]
        public int? ToolId { get; set; }
        // цена
        public double Price { get; set; }
        // объем
        public int Size { get; set; }
        // время сделки
        public DateTime Date { get; set; }
        // ID участника-покупателя
        [ForeignKey(nameof(Customer))]
        public int? CustomerId { get; set; }
        // ID участника-продавца
        [ForeignKey(nameof(Seller))]
        public int? SellerId { get; set; }

        public virtual Tool Tool { get; set; }
        public virtual Member Customer { get; set; }
        public virtual Member Seller { get; set; }
    }
}