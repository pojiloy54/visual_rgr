﻿using System;
using System.Collections.Generic;

namespace Footbool.Models.DatBase
{
    public partial class Season
    {
        public Season()
        {
            Tournaments = new HashSet<Tournament>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
