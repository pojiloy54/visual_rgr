using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Footbool.Models.DatBase;
using System.Linq;

namespace Footbool.Models.StaticTabs
{
    public class CountryTab : StaticTab
    {
        public CountryTab(string h = "", DbSet<Country>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>(); 
            DataColumns.Add("Id");
            DataColumns.Add("Name");
            DataColumns.Add("Link");
            DataColumns.Add("Flag");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Country>? DBS { get; set; }
    }
}
