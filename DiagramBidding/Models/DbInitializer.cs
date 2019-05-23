using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DiagramBidding.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext db)
        {
            db.Tools.Add(new Tool { Currency = "EUR" });
            db.Tools.Add(new Tool { Currency = "USD" });
            db.Tools.Add(new Tool { Currency = "RUB" });

            db.Members.Add(new Member { Name = "Егоров Владимир Васильевич" });
            db.Members.Add(new Member { Name = "Холодкова Ангелина Валерьевна" });

            db.HandbkTrades.Add(new HandbkTrade { ToolId = 1, Price = 5.20, Size = 6, Date = new DateTime(2019, 1, 15, 18, 30, 25), CustomerId = 1, SellerId = 2 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 2, Price = 3.50, Size = 3, Date = new DateTime(2019, 3, 2, 13, 40, 12), CustomerId = 1, SellerId = 2 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 3, Price = 12.40, Size = 15, Date = DateTime.Now, CustomerId = 2, SellerId = 1 });

            base.Seed(db);
        }
    }
}