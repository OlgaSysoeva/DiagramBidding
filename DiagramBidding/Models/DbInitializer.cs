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

            //db.HandbkTrades.Add(new HandbkTrade { ToolId = 1 });

            base.Seed(db);
        }
    }
}