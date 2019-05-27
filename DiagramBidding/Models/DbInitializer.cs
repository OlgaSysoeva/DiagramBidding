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
            db.Tools.Add(new Tool { Id = 1, Currency = "EUR" });
            db.Tools.Add(new Tool { Id = 2, Currency = "USD" });
            db.Tools.Add(new Tool { Id = 3, Currency = "RUB" });

            db.Members.Add(new Member { Id = 1, Name = "Егоров Владимир Васильевич" });
            db.Members.Add(new Member { Id = 2, Name = "Холодкова Ангелина Валерьевна" });

            db.HandbkTrades.Add(new HandbkTrade { ToolId = 1, Price = 2.20, Size = 6, Date = new DateTime(2019, 1, 01, 18, 10, 00), CustomerId = 1, SellerId = 2 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 1, Price = 2.30, Size = 3, Date = new DateTime(2019, 1, 02, 12, 15, 00), CustomerId = 2, SellerId = 1 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 1, Price = 2.25, Size = 8, Date = new DateTime(2019, 1, 03, 14, 23, 00), CustomerId = 1, SellerId = 2 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 1, Price = 2.50, Size = 1, Date = new DateTime(2019, 1, 04, 05, 07, 00), CustomerId = 1, SellerId = 2 });

            db.HandbkTrades.Add(new HandbkTrade { ToolId = 2, Price = 2.10, Size = 5, Date = new DateTime(2019, 1, 01, 06, 12, 00), CustomerId = 1, SellerId = 2 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 2, Price = 2.15, Size = 2, Date = new DateTime(2019, 1, 02, 10, 10, 00), CustomerId = 2, SellerId = 1 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 2, Price = 2.13, Size = 10, Date = new DateTime(2019, 1, 03, 14, 32, 00), CustomerId = 2, SellerId =1 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 2, Price = 2.20, Size = 3, Date = new DateTime(2019, 1, 04, 16, 23, 00), CustomerId = 1, SellerId = 2 });

            db.HandbkTrades.Add(new HandbkTrade { ToolId = 3, Price = 3.09, Size = 15, Date = new DateTime(2019, 1, 01, 06, 12, 00), CustomerId = 2, SellerId = 1 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 3, Price = 3.10, Size = 6, Date = new DateTime(2019, 1, 02, 06, 12, 00), CustomerId = 2, SellerId = 1 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 3, Price = 3.15, Size = 2, Date = new DateTime(2019, 1, 03, 06, 12, 00), CustomerId = 1, SellerId = 2 });
            db.HandbkTrades.Add(new HandbkTrade { ToolId = 3, Price = 3.13, Size = 5, Date = new DateTime(2019, 1, 04, 06, 12, 00), CustomerId = 1, SellerId = 2 });

            base.Seed(db);
        }
    }
}