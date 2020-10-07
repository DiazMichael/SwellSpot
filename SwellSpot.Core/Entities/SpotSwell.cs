using System;

namespace SwellSpot.Core
{
    public class SpotSwell : RichEntity
    {
        public string Description { get; set; }
        public int MaxCapacity { get; set; }
        public int AdjustedCapacity { get; set; }
        public int LogoId { get; set; }
        public int SeatingPlanId { get; set; }
    }
}
