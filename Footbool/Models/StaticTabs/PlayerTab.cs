using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Footbool.Models.DatBase;
using System.Linq;

namespace Footbool.Models.StaticTabs
{
    public class PlayerTab : StaticTab
    {
        public PlayerTab(string h = "", DbSet<Player>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("IdCountry");
            DataColumns.Add("FullName");
            DataColumns.Add("Link");
            DataColumns.Add("IdTeam");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Player>? DBS { get; set; }
    }
}
