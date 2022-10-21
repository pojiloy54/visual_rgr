using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Footbool.Models.DatBase;
using System.Linq;

namespace Footbool.Models.StaticTabs
{
    public class TeamTab : StaticTab
    {
        public TeamTab(string h = "", DbSet<Team>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>(); 
            DataColumns.Add("Id");
            DataColumns.Add("IdCountry");
            DataColumns.Add("Name");
            DataColumns.Add("Gender");
            DataColumns.Add("Link");
            ObjectList = DBS.ToList<object>();
        }
        new public DbSet<Team>? DBS { get; set; }
    }
}
