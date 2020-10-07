using SwellSpot.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Data
{
    public class VenueRepositoryData : IVenueData
    {
        private readonly SwellSpotDbContext db;

        public VenueRepositoryData(SwellSpotDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

        public Venue GetVenue(int id)
        {
            return db.Venues.Find(id);
        }

        public IEnumerable<Venue> GetVenues()
        {
            return db.Venues;
        }
    }
}
