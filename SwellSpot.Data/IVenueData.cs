using SwellSpot.Core;
using System.Collections.Generic;

namespace SwellSpot.Data
{
    public interface IVenueData
    {
        int Commit();
        IEnumerable<Venue> GetVenues();
        Venue GetVenue(int id);
    }
}