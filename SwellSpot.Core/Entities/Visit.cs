using SwellSpot.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Core
{
    public class Visit : RichEntity
    {
        public ICollection<TimeRange> OpeningHours { get; set; } = new List<TimeRange>();
    }
}
