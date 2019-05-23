using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiagramBidding.Models
{
    public class Tool
    {
        // ID валюты
        [Key]
        public int Id { get; set; }
        // название валюты
        public string Currency { get; set; }
    }
}