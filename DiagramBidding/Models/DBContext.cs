using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DiagramBidding.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<HandbkTrade> HandbkTrades { get; set; }
    }
}