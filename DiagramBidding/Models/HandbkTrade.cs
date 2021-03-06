﻿using System;
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
        [Display(Name ="Валюта")]
        public int? ToolId { get; set; }
        // цена
        [Display(Name = "Цена")]
        public double Price { get; set; }
        // объем
        [Display(Name = "Количество")]
        public int Size { get; set; }
        // время сделки
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        // ID участника-покупателя
        [ForeignKey(nameof(Customer))]
        [Display(Name = "Покупатель")]
        public int? CustomerId { get; set; }
        // ID участника-продавца
        [ForeignKey(nameof(Seller))]
        [Display(Name = "Продавец")]
        public int? SellerId { get; set; }

        public virtual Tool Tool { get; set; }
        public virtual Member Customer { get; set; }
        public virtual Member Seller { get; set; }
    }
}