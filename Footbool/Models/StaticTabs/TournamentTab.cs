using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Footbool.Models.DatBase;
using System.Linq;

namespace Footbool.Models.StaticTabs
{
    public class TournamentTab : StaticTab
    {
        public TournamentTab(string h = "", DbSet<Tournament>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("IdTournament");
            DataColumns.Add("IdSeason");
            DataColumns.Add("IdCountry");
            DataColumns.Add("Name");
            DataColumns.Add("Link");
            DataColumns.Add("IdChampion");
            DataColumns.Add("IdTopPlayer");
            ObjectList = DBS.ToList<object>();
        }
        new public DbSet<Tournament>? DBS { get; set; }
    }
}
