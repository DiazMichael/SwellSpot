using SwellSpot.Core;
using System;
using System.Collections.Generic;

namespace SwellSpot.Data
{
    public class SpotRepositoryData : ISpotData
    {
        private readonly SwellSpotDbContext db;

        public SpotRepositoryData(SwellSpotDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

        public SpotSwell GetSpot(int id)
        {
            return db.Spots.Find(id);
        }

        public IEnumerable<SpotSwell> GetSpots()
        {
            return db.Spots;
        }
    }
}
