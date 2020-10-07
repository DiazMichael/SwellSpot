using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Core
{
    public class RichEntity
    {
        public int Id { get; set; }
        public string CreatedAt { get; set; }
        public string LastUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
