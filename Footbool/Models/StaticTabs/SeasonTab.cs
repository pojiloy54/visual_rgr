using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Footbool.Models.DatBase;
using System.Linq;

namespace Footbool.Models.StaticTabs
{
    public class SeasonTab : StaticTab
    {
        public SeasonTab(string h = "", DbSet<Season>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("Name");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Season>? DBS { get; set; }
    }
}
