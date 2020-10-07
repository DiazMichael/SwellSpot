using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Core
{
    public class SeatingPlan : RichEntity
    {
        public int Size { get; set; }
        public int VenueId { get; set; }
        public ICollection<SpotSwell> Spots { get; set; } = new List<SpotSwell>();
    }
}
