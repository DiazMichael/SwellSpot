using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Core
{
    public class Address : RichEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public int VenueId { get; set; }
    }
}
