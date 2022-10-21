using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Footbool.Models.DatBase;
using System.Linq;

namespace Footbool.Models.StaticTabs
{
    public class MatchTab : StaticTab
    {
        public MatchTab(string h = "", DbSet<Match>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("Id");
            DataColumns.Add("IdTournament");
            DataColumns.Add("IdSeason");
            DataColumns.Add("Time");
            DataColumns.Add("Date");
            DataColumns.Add("Referee");
            DataColumns.Add("Venue");
            DataColumns.Add("Place");
            DataColumns.Add("Link");
            DataColumns.Add("IdHomeTeam");
            DataColumns.Add("IdAwayTeam");
            DataColumns.Add("AwayTeamGoals");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Match>? DBS { get; set; }
    }
}
