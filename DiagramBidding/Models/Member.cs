using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiagramBidding.Models
{
    public class Member
    {
        // ID участника
        [Key]
        public int Id { get; set; }
        // имя участника
        public string Name { get; set; }
    }
}