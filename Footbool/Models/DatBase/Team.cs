﻿using System;
using System.Collections.Generic;

namespace Footbool.Models.DatBase
{
    public partial class Team
    {
        public Team()
        {
            MatchIdAwayTeamNavigations = new HashSet<Match>();
            MatchIdHomeTeamNavigations = new HashSet<Match>();
            Tournaments = new HashSet<Tournament>();
        }

        public long Id { get; set; }
        public long? IdCountry { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Link { get; set; } = null!;

        public virtual Country? IdCountryNavigation { get; set; }
        public virtual ICollection<Match> MatchIdAwayTeamNavigations { get; set; }
        public virtual ICollection<Match> MatchIdHomeTeamNavigations { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
