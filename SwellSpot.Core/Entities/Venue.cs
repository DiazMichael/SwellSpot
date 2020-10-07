using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Core
{
    public class Venue : RichEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public ICollection<SeatingPlan> SeatingPlans { get; set; } = new List<SeatingPlan>();
        public Visit Visit { get; set; }
    }
}
