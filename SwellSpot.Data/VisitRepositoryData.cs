using SwellSpot.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Data
{
    public class VisitRepositoryData : IVisitData
    {
        private readonly SwellSpotDbContext db;

        public VisitRepositoryData(SwellSpotDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

        public Visit GetVisit(int id)
        {
            return db.Visits.Find(id);
        }

        public IEnumerable<Visit> GetVisits()
        {
            return db.Visits;
        }
    }
}
