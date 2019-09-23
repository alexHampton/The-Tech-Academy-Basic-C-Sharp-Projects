using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BNB.Models;

namespace BNB.DAL
{
    public class BedAndBreakfastInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<BedAndBreakfastContext>
    {
        protected override void Seed(BedAndBreakfastContext context)
        {
            var Bnbs = new List<Bnb>
            {
                new Bnb{Name="Country Gardens", Address="4236 Garden Path"},
                new Bnb{Name="Country Roads", Address="12 Main Street"},
                new Bnb{Name="Country Hills", Address="1 Private Way"}
            };
            Bnbs.ForEach(x => context.Bnbs.Add(x));
            context.SaveChanges();
        }
    }
}